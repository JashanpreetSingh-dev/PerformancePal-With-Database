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

namespace PerformancePal
{
    public partial class FormSelectTemplate : Form
    {
        private string selectedTemplate = null;
        public FormSelectTemplate()
        {
            InitializeComponent();
            List<string> templateNames = GetListOfTemplatesFromDatabase();
            foreach (string templateName in templateNames)
            {
                comboBoxTemplates.Items.Add(templateName);
            }

            //Show first item inside combobox
            if (comboBoxTemplates.SelectedItem != null)
            {
                comboBoxTemplates.SelectedIndex = 0;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxTemplates.SelectedItem != null)
            {
                this.selectedTemplate = comboBoxTemplates.SelectedItem.ToString();
            }
        }

        /// <summary>
        /// Get the selected template, this is further used to access the database and its tables.
        /// </summary>
        /// <returns></returns>
        public string GetSelectedTemplate()
        {
            return this.selectedTemplate;    
        }

        /// <summary>
        /// Get a list of all the Template tables from the Sql Database.
        /// </summary>
        /// <returns> A list of Strings containing all the names of the templates. </returns>
        public static List<String> GetListOfTemplatesFromDatabase()
        {
            String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PerformancePal.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            List<string> tables = new List<string>();
            DataTable dt = connection.GetSchema("Tables");
            connection.Close();
            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                tables.Add(tablename);
            }
            return tables;

        }
    }
}
