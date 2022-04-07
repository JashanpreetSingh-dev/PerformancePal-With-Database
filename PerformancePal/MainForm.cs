using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;

namespace PerformancePal
{
    public partial class MainForm : Form
    {
        //key value is the template name, values are list of data field names
        Dictionary<string, List<string>> templates = new Dictionary<string, List<String>>();

        //Key is the template name and value is the list of entries for the template key.
        Dictionary<string, List<List<string>>> data = new Dictionary<string, List<List<string>>>();

        public MainForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Click event responsible for displaying sending the user to a form to create data field names and a template name
        /// for the type of data they would like to keep track of.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddTemplate dlg = new FormAddTemplate();
            if (dlg.ShowDialog(this) == DialogResult.OK) { }
            //{
            //    string templateName = dlg.GetTemplateName();
            //    if (!templates.ContainsKey(templateName))
            //    {
            //        templates.Add(templateName, dlg.GetDataNames());
            //        data.Add(templateName, new List<List<string>>());
            //    }
            //}
        }

        /// <summary>
        /// Click event responsible for sending the user to a form to select a previously created template of data fields, in order to enter
        /// decimal values to previously created data fields.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedTemplate = null;
            FormSelectTemplate dlg = new FormSelectTemplate();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                selectedTemplate = dlg.GetSelectedTemplate();
            }

            if (selectedTemplate != null)
            {
                FormAddData child = new FormAddData(selectedTemplate);
                child.MdiParent = this;
                child.Show();
            }
        }

        /// <summary>
        /// Add list of data values to list of data values corresponding to template used.
        /// 
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="entryData"></param>
        public void AddData(string templateName)
        {
            //if (this.data.ContainsKey(templateName))
            //{
            //    data[templateName].Add(entryData);
            //}
        }

        /// <summary>
        /// Click event responsible for creating mdi child of a graph of stored templates and values of data entries.
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectGraph graph = new FormSelectGraph(templates, data);
            graph.MdiParent = this;
            graph.Show();
        }
    }
}
