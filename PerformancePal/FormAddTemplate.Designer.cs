namespace PerformancePal
{
    partial class FormAddTemplate
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBoxDataNames = new System.Windows.Forms.ListBox();
            this.labelDataName = new System.Windows.Forms.Label();
            this.textBoxInputDataName = new System.Windows.Forms.TextBox();
            this.labelTemplateName = new System.Windows.Forms.Label();
            this.textBoxInputTemplateName = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonConfirm);
            this.groupBox.Controls.Add(this.buttonCancel);
            this.groupBox.Controls.Add(this.buttonAdd);
            this.groupBox.Controls.Add(this.buttonRemove);
            this.groupBox.Controls.Add(this.listBoxDataNames);
            this.groupBox.Controls.Add(this.labelDataName);
            this.groupBox.Controls.Add(this.textBoxInputDataName);
            this.groupBox.Controls.Add(this.labelTemplateName);
            this.groupBox.Controls.Add(this.textBoxInputTemplateName);
            this.groupBox.Location = new System.Drawing.Point(231, 75);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(398, 293);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonConfirm.Location = new System.Drawing.Point(305, 226);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(9, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(314, 90);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(233, 90);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listBoxDataNames
            // 
            this.listBoxDataNames.FormattingEnabled = true;
            this.listBoxDataNames.ItemHeight = 16;
            this.listBoxDataNames.Location = new System.Drawing.Point(9, 121);
            this.listBoxDataNames.Name = "listBoxDataNames";
            this.listBoxDataNames.Size = new System.Drawing.Size(380, 84);
            this.listBoxDataNames.TabIndex = 4;
            // 
            // labelDataName
            // 
            this.labelDataName.AutoSize = true;
            this.labelDataName.Location = new System.Drawing.Point(6, 93);
            this.labelDataName.Name = "labelDataName";
            this.labelDataName.Size = new System.Drawing.Size(101, 16);
            this.labelDataName.TabIndex = 3;
            this.labelDataName.Text = "Data field name";
            // 
            // textBoxInputDataName
            // 
            this.textBoxInputDataName.Location = new System.Drawing.Point(125, 91);
            this.textBoxInputDataName.Name = "textBoxInputDataName";
            this.textBoxInputDataName.Size = new System.Drawing.Size(102, 22);
            this.textBoxInputDataName.TabIndex = 2;
            // 
            // labelTemplateName
            // 
            this.labelTemplateName.AutoSize = true;
            this.labelTemplateName.Location = new System.Drawing.Point(6, 63);
            this.labelTemplateName.Name = "labelTemplateName";
            this.labelTemplateName.Size = new System.Drawing.Size(113, 16);
            this.labelTemplateName.TabIndex = 1;
            this.labelTemplateName.Text = "Name of template";
            // 
            // textBoxInputTemplateName
            // 
            this.textBoxInputTemplateName.Location = new System.Drawing.Point(125, 60);
            this.textBoxInputTemplateName.Name = "textBoxInputTemplateName";
            this.textBoxInputTemplateName.Size = new System.Drawing.Size(264, 22);
            this.textBoxInputTemplateName.TabIndex = 0;
            // 
            // FormAddTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Name = "FormAddTemplate";
            this.Text = "New template";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelTemplateName;
        private System.Windows.Forms.TextBox textBoxInputTemplateName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListBox listBoxDataNames;
        private System.Windows.Forms.Label labelDataName;
        private System.Windows.Forms.TextBox textBoxInputDataName;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
    }
}