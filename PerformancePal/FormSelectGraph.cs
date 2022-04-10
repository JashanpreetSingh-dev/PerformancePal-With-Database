using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PerformancePal;

namespace PerformancePal
{
    /// <summary>
    /// This class is responsible for generating graphs based on what template of data fields is selected and 
    /// the entries of data values.
    /// </summary>
    public partial class FormSelectGraph : Form
    {
        private string selectedTemplate;
        private string selectedDataField;
        private List<string> templates;
        private List<string> templateValues;

        public FormSelectGraph(Dictionary<String, List<String>> templates, Dictionary<String, List<List<String>>> templateValues)
        {
            InitializeComponent();
            this.templates = FormSelectTemplate.GetListOfTemplatesFromDatabase();

            foreach (var key in this.templates)
            {
                comboBoxTemplateName.Items.Add(key);
            }
        }

        /// <summary>
        /// Click event responsible for clearing the data field combo box when the template combobox is changed.
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTemplateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedTemplate = comboBoxTemplateName.SelectedItem.ToString();
            this.templateValues = FormAddData.GetColumnNames(selectedTemplate);
            comboBoxDataFields.Items.Clear();
            for(int i = 0; i < this.templateValues.Count-1; i++)
            {
                comboBoxDataFields.Items.Add(this.templateValues[i]);
            }
            //foreach (var dataField in this.templateValues)
            //{
            //}
        }

        /// <summary>
        /// Click event responsible for setting the selected datavalues
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDataFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedDataField = comboBoxDataFields.SelectedIndex.ToString();
            this.templateValues = FormAddData.GetColumnNames(this.selectedTemplate);
        }


        /// <summary>
        /// Click event responsible for generating the graph based on what is selected in the combo boxes.
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenerate_Click(object sender, EventArgs e){
            this.chartData.Series.Clear();
            this.chartData.Titles.Clear();
            this.chartData.Titles.Add(this.selectedTemplate);
            if (this.selectedTemplate.Length > 0 && this.selectedDataField.Length > 0)
            {
                List<int> dataVals = getDataValuesForTheGraph(getSelectedField());
                List<String> dateVals = getDateValuesForTheGraph();
                this.chartData.Series.Add(getSelectedField());
                for (int i = 0; i < dataVals.Count(); i++)
                {
                    if (dataVals[i] > chartData.ChartAreas[0].AxisY.Maximum)
                    {
                        chartData.ChartAreas[0].AxisY.Maximum = dataVals[i];
                    }
                    this.chartData.Series[getSelectedField()].Points.AddXY(dateVals[i], dataVals[i]); 
                }
                this.label1.Text = createAnalysis(dataVals);
                this.label2.Text = checkOutliers(getMean(dataVals), getStandardDeviation(dataVals), dataVals, dateVals);

            }
        }

        /// <summary>
        /// Get the selected field of the template
        /// </summary>
        /// <returns>A string</returns>
        public string getSelectedField()
        {
            string selectedField = comboBoxDataFields.SelectedItem.ToString();
            return selectedField;
        }

        /// <summary>
        /// Get the name of the selected template from the application.
        /// </summary>
        /// <returns> A string </returns>
        public string getSelectedTemplate()
        {
            string selectedTemplate = comboBoxTemplateName.SelectedIndex.ToString();
            return selectedTemplate;
        }

        /// <summary>
        /// Get the values of data of a particular field from the table in the database.
        /// </summary>
        /// <returns> A list of integers</returns>
        public List<int> getDataValuesForTheGraph(string selectedField)
        {
            List<int> dataValues = new List<int>();
            String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PerformancePal.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sqlCommand = "Select " + getSelectedField() + " from " + this.selectedTemplate; 
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int data = Int32.Parse((string)reader[0]);
                //MessageBox.Show(data.ToString());
                dataValues.Add(data);
            }
            connection.Close();
            return dataValues;
        }

        /// <summary>
        /// Get the dateAdded Values for the corresponding dataValues to be added to the graph.
        /// </summary>
        /// <param name="selectedField"></param>
        /// <returns></returns>
        public List<string> getDateValuesForTheGraph()
        {
            List<string> dataValues = new List<string>();
            String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PerformancePal.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sqlCommand = "Select DateAdded from " + this.selectedTemplate;
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string date = reader[0].ToString();
                dataValues.Add(date);
            }
            connection.Close();
            return dataValues;
        }

        /// <summary>
        /// Create a basic analysis comprising of the max and min values of the dataset selected.
        /// </summary>
        /// <param name="data">The dataset which is selected</param>
        /// <returns>A string value ->  the analysis </returns>
        public string createAnalysis(List<int> data)
        {
            string meanStatement = "The mean value of " + getSelectedField() + " for " + this.selectedTemplate + " is " + getMean(data) + ".";
            string sdDeviationStatement = "The standard deviation is " + getStandardDeviation(data);
            int max = data.Max();
            int min = data.Min();
            string maxMinStatement = "The max number of " + getSelectedField() + " is " + max + " and the min is " + min + ".";
            return meanStatement + "\n" + sdDeviationStatement + "\n" + maxMinStatement;
        }

        /// <summary>
        /// Return the mean value of a particular dataset.
        /// </summary>
        /// <param name="data"> the data set for which the mean is to be calculated.</param>
        /// <returns>The mean value of type double </returns>
        public static double getMean(List<int> data)
        {
            return data.Average();

        }

        /// <summary>
        /// Return the standard deviation of a particular dataset.
        /// </summary>
        /// <param name="data"> The data set for which the standard devuation is to be calculated</param>
        /// <returns> The standard deviation of type double.</returns>
        public static double getStandardDeviation(List<int> data)
        {
            double average = data.Average();
            double sum = data.Sum(d => Math.Pow(d - average, 2));
            return Math.Round(Math.Sqrt((sum) / data.Count()), 4);
        }

        /// <summary>
        /// Return the z-score for a particular value to check if the value os unusual for a dataset.
        /// </summary>
        /// <param name="value"> The integer value </param>
        /// <param name="mean"></param>
        /// <param name="standardDeviation"></param>
        /// <returns>The z score value of type double</returns>
        public static double getZScore(int value, double mean, double standardDeviation)
        {
            double zScore = Math.Round(((value - mean) / standardDeviation), 4);
            return zScore;
        }

        /// <summary>
        /// Create analysis for the outliers for a certain dataset.
        /// </summary>
        /// <param name="mean"> The mean of the dataset</param>
        /// <param name="standardDeviation"> The standard deviation of that dataset</param>
        /// <param name="data"> The dataset that the user saved over time</param>
        /// <param name="date"> The date values for that particular datasets</param>
        /// <returns>A string value</returns>
        public string checkOutliers(double mean, double standardDeviation, List<int> data, List<string> date)
        {
            List<int> dataWithoutOutliers = new List<int>();
            List<int> outliers = new List<int>();
            double newMean;
            double newStandardDeviation;
            foreach (int i in data)
            {
                if(getZScore(i, mean, standardDeviation) > 2 || getZScore(i, mean, standardDeviation) < -2)
                {
                    outliers.Add(i);
                }
                else
                {
                    dataWithoutOutliers.Add(i);
                }
            }
            if(outliers.Count > 0)
            {
                newMean = getMean(dataWithoutOutliers);
                newStandardDeviation = getStandardDeviation(dataWithoutOutliers);
                string outlierStatement = "Some unusual values for " + getSelectedField() + " were found!\n";
                string outlierDescription = "";
                for(int i = 0; i < data.Count; i++ )
                {
                    foreach (int j in outliers)
                    {
                        if (j == i)
                        {
                            outlierDescription += i + getSelectedField() + " on " + date[i] + "\n";
                        }
                    }
                }
                string meanStatement = "The actual mean value of " + getSelectedField() + " without outliers for " + this.selectedTemplate + " is " + newMean + ".\n";
                string sdDeviationStatement = "The standard deviation without outliers is " + newStandardDeviation + ".\n";
                string finalMeanAndStandardDeviation =  meanStatement + sdDeviationStatement;
                return outlierStatement + outlierDescription + finalMeanAndStandardDeviation;
            }
            else
            {
                return "";
            }
            
        }


    }
}
