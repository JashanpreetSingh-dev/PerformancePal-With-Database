using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Data.SqlClient;

namespace PerformancePal
{
    public partial class FormAddTemplate : Form
    {
        private List<string> dataNames = new List<string>();
        private string templateName = null;

        public FormAddTemplate()
        {
            InitializeComponent();


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String dataToAdd = textBoxInputDataName.Text;

            //Check if input was entered in text field
            if (dataToAdd.Length != 0)
            {
                //check if data name is not in the list box already
                if (!listBoxDataNames.Items.Contains(dataToAdd))
                {
                    //Add item to list box
                    listBoxDataNames.Items.Add(dataToAdd);
                }

                //Clear the text field
                textBoxInputDataName.Clear();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            String dataToRemove = textBoxInputDataName.Text;

            //Check if input was entered in text field
            if (dataToRemove.Length != 0)
            {
                //Search the list box
                if (listBoxDataNames.Items.Contains(dataToRemove))
                {
                    listBoxDataNames.Items.Remove(dataToRemove);
                }

                //Clear the text field
                textBoxInputDataName.Clear();
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            List<String> columnNames = new List<string>();
            for (int i = 0; i < listBoxDataNames.Items.Count; i++)
            {
                columnNames.Add(listBoxDataNames.Items[i].ToString());
            }

            this.dataNames = columnNames;
            this.templateName = textBoxInputTemplateName.Text;

            ExecuteCommand(createCommandForSqlTable(this.dataNames));


        }

        public List<String> GetDataNames()
        {
            return this.dataNames;
        }

        public string GetTemplateName()
        {
            return this.templateName;
        }

        /// <summary>
        /// Helper function for the function ExecuteCommand() which creates an Sql create table
        /// statement dynamically.
        /// </summary>
        /// <param name="listOfColumns">This is the list of all the fields the user wants in their template</param>
        /// <returns>A formatted SQL Create table command. </returns>
        public String createCommandForSqlTable(List<String> listOfColumns)
        {
            
            String sql = @"CREATE TABLE [dbo].[" + textBoxInputTemplateName.Text.ToString() + "](";
            for (int i = 0; i < listOfColumns.Count; i++)
            {
                sql += listOfColumns[i].ToString() + " NVARCHAR(25) NOT NULL,";
            }
            sql += " DateAdded DATETIME NOT NULL";
            //sql = sql.Remove(sql.Length - 1);
            sql += ");";
            return sql;
        }

        /// <summary>
        /// Create a table in the database
        /// </summary>
        /// <param name="sqlCommand"> A string -> an Sql Command.</param>
        public static void ExecuteCommand(String sqlCommand)
        {
            String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PerformancePal.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(sqlCommand, connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
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
