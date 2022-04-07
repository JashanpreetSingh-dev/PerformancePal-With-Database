namespace PerformancePal
{
    partial class FormSelectGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxDataFields = new System.Windows.Forms.ComboBox();
            this.comboBoxTemplateName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonGenerate);
            this.groupBox.Controls.Add(this.chartData);
            this.groupBox.Controls.Add(this.comboBoxDataFields);
            this.groupBox.Controls.Add(this.comboBoxTemplateName);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(672, 597);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(394, 58);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(90, 23);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // chartData
            // 
            chartArea5.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartData.Legends.Add(legend5);
            this.chartData.Location = new System.Drawing.Point(27, 100);
            this.chartData.Name = "chartData";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartData.Series.Add(series5);
            this.chartData.Size = new System.Drawing.Size(629, 479);
            this.chartData.TabIndex = 2;
            this.chartData.Text = "chart1";
            this.chartData.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // comboBoxDataFields
            // 
            this.comboBoxDataFields.FormattingEnabled = true;
            this.comboBoxDataFields.Location = new System.Drawing.Point(261, 57);
            this.comboBoxDataFields.Name = "comboBoxDataFields";
            this.comboBoxDataFields.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDataFields.TabIndex = 1;
            this.comboBoxDataFields.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataFields_SelectedIndexChanged);
            // 
            // comboBoxTemplateName
            // 
            this.comboBoxTemplateName.FormattingEnabled = true;
            this.comboBoxTemplateName.Location = new System.Drawing.Point(134, 57);
            this.comboBoxTemplateName.Name = "comboBoxTemplateName";
            this.comboBoxTemplateName.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTemplateName.TabIndex = 0;
            this.comboBoxTemplateName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemplateName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 691);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // FormSelectGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 777);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox);
            this.Name = "FormSelectGraph";
            this.Text = "Select a graph";
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.ComboBox comboBoxDataFields;
        private System.Windows.Forms.ComboBox comboBoxTemplateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}