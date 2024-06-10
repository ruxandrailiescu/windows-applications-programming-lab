namespace ExamSubject1
{
    partial class AddRegistrationForm
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
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.cbAccessPackage = new System.Windows.Forms.ComboBox();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbNoOfPasses = new System.Windows.Forms.Label();
            this.lbAccessPackage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudNoOfPasses = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfPasses)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(204, 37);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(182, 20);
            this.tbCompanyName.TabIndex = 0;
            // 
            // cbAccessPackage
            // 
            this.cbAccessPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccessPackage.FormattingEnabled = true;
            this.cbAccessPackage.Location = new System.Drawing.Point(204, 122);
            this.cbAccessPackage.Name = "cbAccessPackage";
            this.cbAccessPackage.Size = new System.Drawing.Size(182, 21);
            this.cbAccessPackage.TabIndex = 2;
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(86, 34);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lbCompanyName.TabIndex = 3;
            this.lbCompanyName.Text = "Company Name";
            // 
            // lbNoOfPasses
            // 
            this.lbNoOfPasses.AutoSize = true;
            this.lbNoOfPasses.Location = new System.Drawing.Point(86, 79);
            this.lbNoOfPasses.Name = "lbNoOfPasses";
            this.lbNoOfPasses.Size = new System.Drawing.Size(93, 13);
            this.lbNoOfPasses.TabIndex = 4;
            this.lbNoOfPasses.Text = "Number of Passes";
            // 
            // lbAccessPackage
            // 
            this.lbAccessPackage.AutoSize = true;
            this.lbAccessPackage.Location = new System.Drawing.Point(86, 127);
            this.lbAccessPackage.Name = "lbAccessPackage";
            this.lbAccessPackage.Size = new System.Drawing.Size(88, 13);
            this.lbAccessPackage.TabIndex = 5;
            this.lbAccessPackage.Text = "Access Package";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(89, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(311, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudNoOfPasses
            // 
            this.nudNoOfPasses.Location = new System.Drawing.Point(204, 79);
            this.nudNoOfPasses.Name = "nudNoOfPasses";
            this.nudNoOfPasses.Size = new System.Drawing.Size(182, 20);
            this.nudNoOfPasses.TabIndex = 8;
            // 
            // AddRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 348);
            this.Controls.Add(this.nudNoOfPasses);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbAccessPackage);
            this.Controls.Add(this.lbNoOfPasses);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.cbAccessPackage);
            this.Controls.Add(this.tbCompanyName);
            this.Name = "AddRegistrationForm";
            this.Text = "AddRegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfPasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.ComboBox cbAccessPackage;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label lbNoOfPasses;
        private System.Windows.Forms.Label lbAccessPackage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudNoOfPasses;
    }
}