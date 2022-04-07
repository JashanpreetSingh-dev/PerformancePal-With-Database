namespace PerformancePal
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonTemplate = new System.Windows.Forms.ToolStripDropDownButton();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonData = new System.Windows.Forms.ToolStripDropDownButton();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonGraph = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripDropDownButtonTemplate, this.toolStripDropDownButtonData, this.toolStripDropDownButtonGraph});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonTemplate
            // 
            this.toolStripDropDownButtonTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonTemplate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addNewToolStripMenuItem});
            this.toolStripDropDownButtonTemplate.Image = ((System.Drawing.Image) (resources.GetObject("toolStripDropDownButtonTemplate.Image")));
            this.toolStripDropDownButtonTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonTemplate.Name = "toolStripDropDownButtonTemplate";
            this.toolStripDropDownButtonTemplate.Size = new System.Drawing.Size(82, 24);
            this.toolStripDropDownButtonTemplate.Text = "template";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.addNewToolStripMenuItem.Text = "Add new";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // toolStripDropDownButtonData
            // 
            this.toolStripDropDownButtonData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addToolStripMenuItem});
            this.toolStripDropDownButtonData.Image = ((System.Drawing.Image) (resources.GetObject("toolStripDropDownButtonData.Image")));
            this.toolStripDropDownButtonData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonData.Name = "toolStripDropDownButtonData";
            this.toolStripDropDownButtonData.Size = new System.Drawing.Size(52, 24);
            this.toolStripDropDownButtonData.Text = "data";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // toolStripDropDownButtonGraph
            // 
            this.toolStripDropDownButtonGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonGraph.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.viewToolStripMenuItem});
            this.toolStripDropDownButtonGraph.Image = ((System.Drawing.Image) (resources.GetObject("toolStripDropDownButtonGraph.Image")));
            this.toolStripDropDownButtonGraph.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonGraph.Name = "toolStripDropDownButtonGraph";
            this.toolStripDropDownButtonGraph.Size = new System.Drawing.Size(61, 24);
            this.toolStripDropDownButtonGraph.Text = "graph";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.viewToolStripMenuItem.Text = "view";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "PerformancePal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonTemplate;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonData;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonGraph;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    }
}

