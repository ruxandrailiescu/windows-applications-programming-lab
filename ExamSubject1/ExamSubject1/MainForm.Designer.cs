namespace ExamSubject1
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
            this.listViewRegistrations = new System.Windows.Forms.ListView();
            this.btnAddReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewRegistrations
            // 
            this.listViewRegistrations.HideSelection = false;
            this.listViewRegistrations.Location = new System.Drawing.Point(276, 41);
            this.listViewRegistrations.Name = "listViewRegistrations";
            this.listViewRegistrations.Size = new System.Drawing.Size(258, 316);
            this.listViewRegistrations.TabIndex = 0;
            this.listViewRegistrations.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddReg
            // 
            this.btnAddReg.Location = new System.Drawing.Point(29, 333);
            this.btnAddReg.Name = "btnAddReg";
            this.btnAddReg.Size = new System.Drawing.Size(121, 24);
            this.btnAddReg.TabIndex = 1;
            this.btnAddReg.Text = "Add Registration";
            this.btnAddReg.UseVisualStyleBackColor = true;
            this.btnAddReg.Click += new System.EventHandler(this.btnAddReg_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 408);
            this.Controls.Add(this.btnAddReg);
            this.Controls.Add(this.listViewRegistrations);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewRegistrations;
        private System.Windows.Forms.Button btnAddReg;
    }
}

