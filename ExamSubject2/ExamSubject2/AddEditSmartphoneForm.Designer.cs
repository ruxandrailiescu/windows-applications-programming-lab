namespace ExamSubject2
{
    partial class AddEditSmartphoneForm
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
            this.components = new System.ComponentModel.Container();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.nudUnits = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.cbProdId = new System.Windows.Forms.ComboBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbUnits = new System.Windows.Forms.Label();
            this.lbReleaseDate = new System.Windows.Forms.Label();
            this.lbProdId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(167, 24);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(198, 20);
            this.nudId.TabIndex = 0;
            this.nudId.Validating += new System.ComponentModel.CancelEventHandler(this.nudId_Validating);
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(167, 71);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(198, 20);
            this.tbModel.TabIndex = 1;
            this.tbModel.Validating += new System.ComponentModel.CancelEventHandler(this.tbModel_Validating);
            // 
            // nudUnits
            // 
            this.nudUnits.Location = new System.Drawing.Point(167, 118);
            this.nudUnits.Name = "nudUnits";
            this.nudUnits.Size = new System.Drawing.Size(198, 20);
            this.nudUnits.TabIndex = 2;
            this.nudUnits.Validating += new System.ComponentModel.CancelEventHandler(this.nudUnits_Validating);
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(167, 165);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(198, 20);
            this.nudPrice.TabIndex = 3;
            this.nudPrice.Validating += new System.ComponentModel.CancelEventHandler(this.nudPrice_Validating);
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Location = new System.Drawing.Point(167, 212);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(198, 20);
            this.dtpReleaseDate.TabIndex = 4;
            this.dtpReleaseDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpReleaseDate_Validating);
            // 
            // cbProdId
            // 
            this.cbProdId.FormattingEnabled = true;
            this.cbProdId.Location = new System.Drawing.Point(167, 259);
            this.cbProdId.Name = "cbProdId";
            this.cbProdId.Size = new System.Drawing.Size(198, 21);
            this.cbProdId.TabIndex = 5;
            this.cbProdId.Validating += new System.ComponentModel.CancelEventHandler(this.cbProdId_Validating);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(59, 24);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 6;
            this.lbId.Text = "Id";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(59, 72);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(36, 13);
            this.lbModel.TabIndex = 7;
            this.lbModel.Text = "Model";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(59, 168);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Price";
            // 
            // lbUnits
            // 
            this.lbUnits.AutoSize = true;
            this.lbUnits.Location = new System.Drawing.Point(59, 120);
            this.lbUnits.Name = "lbUnits";
            this.lbUnits.Size = new System.Drawing.Size(31, 13);
            this.lbUnits.TabIndex = 9;
            this.lbUnits.Text = "Units";
            // 
            // lbReleaseDate
            // 
            this.lbReleaseDate.AutoSize = true;
            this.lbReleaseDate.Location = new System.Drawing.Point(59, 216);
            this.lbReleaseDate.Name = "lbReleaseDate";
            this.lbReleaseDate.Size = new System.Drawing.Size(72, 13);
            this.lbReleaseDate.TabIndex = 10;
            this.lbReleaseDate.Text = "Release Date";
            // 
            // lbProdId
            // 
            this.lbProdId.AutoSize = true;
            this.lbProdId.Location = new System.Drawing.Point(59, 264);
            this.lbProdId.Name = "lbProdId";
            this.lbProdId.Size = new System.Drawing.Size(50, 13);
            this.lbProdId.TabIndex = 11;
            this.lbProdId.Text = "Producer";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(46, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(350, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 35);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEditSmartphoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 424);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbProdId);
            this.Controls.Add(this.lbReleaseDate);
            this.Controls.Add(this.lbUnits);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.cbProdId);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudUnits);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.nudId);
            this.Name = "AddEditSmartphoneForm";
            this.Text = "AddEditSmartphones";
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.NumericUpDown nudUnits;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.ComboBox cbProdId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbUnits;
        private System.Windows.Forms.Label lbReleaseDate;
        private System.Windows.Forms.Label lbProdId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}