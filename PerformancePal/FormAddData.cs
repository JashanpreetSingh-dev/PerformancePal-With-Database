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
using PerformancePal;


namespace PerformancePal
{
    public partial class FormAddData : Form
    {
        private List<string> dataNames;
        private List<TextBox> dataValues;

        /// <summary>
        /// Form responsible of displaying dynaming text boxes and buttons based on inputed template and list of data fields.
        ///
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="dataNames"></param>
        public FormAddData(string templateName)
        {
            InitializeComponent();
            this.Text = templateName;
            this.dataNames = new List<string>();
            this.dataValues = new List<TextBox>();

            // Sets the spacing
            int left = 200;
            int top = 100;
            int leftTwo = 300;

            //Dynamicallly create the text boxes and labels
            this.dataNames = GetColumnNames(this.Text);
            for (int i = 0; i < dataNames.Count-1; i++)
            {
                Label label = new Label();
                label.Left = left;
                label.Top = top;
                label.Text = dataNames[i];

                TextBox textbox = new TextBox();
                textbox.Name = "textBoxAddData" + i;
                dataValues.Add(textbox);
                textbox.Top = top;
                textbox.Left = leftTwo;

                this.Controls.Add(label);
                this.Controls.Add(textbox);
                top += label.Height + 5;
            }

            //Create the submit button of data
            Button addButton = new Button();
            addButton.Text = "Add Data";
            addButton.Name = "AddButton";
            addButton.Top = top;
            addButton.Left = 250;
            this.Controls.Add(addButton);

            addButton.DialogResult = DialogResult.OK;
            addButton.Click += new EventHandler(button_add_Click);
        }

        /// <summary>
        /// Click event for when the add data button is clicked.
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteCommand(CreateSqlInsertCommand(GetDataValues()));
            }
            catch (Exception)
            {
                CleanForm();
                MessageBox.Show("The textboxes only accept numbers!");
            }
        }

        /// <summary>
        /// This function returns a formatted SQL command as a string on being given the
        /// data values as a list of integers
        /// </summary>
        /// <param name="dataValues"> a list of integer</param>
        /// <returns>a List of strings </returns>
        private string CreateSqlInsertCommand(List<String> dataValues)
        {
            DateTime now = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string currentDate = now.ToString(format);
            String SqlCommand = "INSERT INTO " + this.Text + " VALUES (";
            foreach (String value in dataValues)
            {
                SqlCommand += value + ",";
            }
            SqlCommand += "@date)";
            return SqlCommand;
        }

        /// <summary>
        /// Get the  names of the columns of the selected template/table
        /// </summary>
        /// <returns> a list of strings </returns>
        public static List<string> GetColumnNames(string templateName)
        {
            List<string> colList = new List<string>();
            DataTable dataTable = new DataTable();
            String Connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PerformancePal.mdf;Integrated Security=True";
            string cmdString = "SELECT * FROM " + templateName.ToString() + ";";
            if (Connection != null)
            {
                try
                {
                    using (SqlDataAdapter dataContent = new SqlDataAdapter(cmdString, Connection))
                    {
                        dataContent.Fill(dataTable);
                        foreach (DataColumn col in dataTable.Columns)
                        {
                            colList.Add(col.ColumnName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return colList;
        }

        /// <summary>
        /// Get the values for the template columns from the textboxes.
        /// </summary>
        /// <returns>a list of strings</returns>
        public List<string> GetDataValues()
        {
            List<string> dataValueStrings = new List<string>();
            for (int i = 0; i < this.dataValues.Count; i++){
                double numericValue;
                string textBoxValue = this.dataValues[i].Text;
                if(double.TryParse(textBoxValue, out numericValue) == false)
                {
                    throw new Exception();
                }
                else
                {
                    dataValueStrings.Add(textBoxValue);
                }
                }
            return dataValueStrings;
                   
        }

        /// <summary>
        /// A helper function to clear all the textboxes in case of an error.
        /// </summary>
        private void CleanForm()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        /// <summary>
        /// Create a table in the database
        /// </summary>
        /// <param name="sqlCommand"> A string -> an Sql Command.</param>
        public void ExecuteCommand(String sqlCommand)
        {
            String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PerformancePal.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sqlCommand, connection);
            try
            {
                connection.Open();
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added Successfully");
                connection.Close();
                CleanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                //Console.ReadKey();
            }

        }
    }
}
