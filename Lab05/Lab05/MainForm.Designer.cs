namespace Lab05
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTile = new System.Windows.Forms.Button();
            this.btnSmallIcon = new System.Windows.Forms.Button();
            this.btnLargeIcon = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSSN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lvParticipants = new System.Windows.Forms.ListView();
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.binarySerializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLSerializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeXML = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeXML = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONSerializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTile);
            this.groupBox1.Controls.Add(this.btnSmallIcon);
            this.groupBox1.Controls.Add(this.btnLargeIcon);
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnDetails);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSSN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpBirthDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Participant";
            // 
            // btnTile
            // 
            this.btnTile.Location = new System.Drawing.Point(454, 158);
            this.btnTile.Name = "btnTile";
            this.btnTile.Size = new System.Drawing.Size(76, 34);
            this.btnTile.TabIndex = 15;
            this.btnTile.Text = "Tile";
            this.btnTile.UseVisualStyleBackColor = true;
            this.btnTile.Click += new System.EventHandler(this.btnTile_Click);
            // 
            // btnSmallIcon
            // 
            this.btnSmallIcon.Location = new System.Drawing.Point(346, 158);
            this.btnSmallIcon.Name = "btnSmallIcon";
            this.btnSmallIcon.Size = new System.Drawing.Size(76, 34);
            this.btnSmallIcon.TabIndex = 14;
            this.btnSmallIcon.Text = "Small Icon";
            this.btnSmallIcon.UseVisualStyleBackColor = true;
            this.btnSmallIcon.Click += new System.EventHandler(this.btnSmallIcon_Click);
            // 
            // btnLargeIcon
            // 
            this.btnLargeIcon.Location = new System.Drawing.Point(238, 158);
            this.btnLargeIcon.Name = "btnLargeIcon";
            this.btnLargeIcon.Size = new System.Drawing.Size(76, 34);
            this.btnLargeIcon.TabIndex = 13;
            this.btnLargeIcon.Text = "Large Icon";
            this.btnLargeIcon.UseVisualStyleBackColor = true;
            this.btnLargeIcon.Click += new System.EventHandler(this.btnLargeIcon_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(130, 158);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(76, 34);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(22, 158);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(76, 34);
            this.btnDetails.TabIndex = 11;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(536, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Participant";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "SSN";
            // 
            // tbSSN
            // 
            this.tbSSN.Location = new System.Drawing.Point(455, 74);
            this.tbSSN.Name = "tbSSN";
            this.tbSSN.Size = new System.Drawing.Size(200, 22);
            this.tbSSN.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbFemale);
            this.panel1.Controls.Add(this.cbMale);
            this.panel1.Location = new System.Drawing.Point(455, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 44);
            this.panel1.TabIndex = 6;
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Location = new System.Drawing.Point(123, 12);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(72, 20);
            this.cbFemale.TabIndex = 1;
            this.cbFemale.Text = "Female";
            this.cbFemale.UseVisualStyleBackColor = true;
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Location = new System.Drawing.Point(21, 12);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(56, 20);
            this.cbMale.TabIndex = 0;
            this.cbMale.Text = "Male";
            this.cbMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birth Date";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(98, 117);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(185, 22);
            this.dtpBirthDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(98, 74);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(185, 22);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            this.tbFirstName.Validated += new System.EventHandler(this.tbFirstName_Validated);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(98, 32);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(185, 22);
            this.tbLastName.TabIndex = 0;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            this.tbLastName.Validated += new System.EventHandler(this.tbLastName_Validated);
            // 
            // lvParticipants
            // 
            this.lvParticipants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLastName,
            this.colFirstName,
            this.colBirthDate,
            this.colGender,
            this.colSSN});
            this.lvParticipants.FullRowSelect = true;
            this.lvParticipants.GridLines = true;
            this.lvParticipants.HideSelection = false;
            this.lvParticipants.Location = new System.Drawing.Point(29, 285);
            this.lvParticipants.Name = "lvParticipants";
            this.lvParticipants.Size = new System.Drawing.Size(759, 240);
            this.lvParticipants.TabIndex = 1;
            this.lvParticipants.UseCompatibleStateImageBehavior = false;
            this.lvParticipants.View = System.Windows.Forms.View.Details;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Last Name";
            this.colLastName.Width = 150;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "First Name";
            this.colFirstName.Width = 150;
            // 
            // colBirthDate
            // 
            this.colBirthDate.Text = "Birth Date";
            this.colBirthDate.Width = 150;
            // 
            // colGender
            // 
            this.colGender.Text = "Gender";
            this.colGender.Width = 150;
            // 
            // colSSN
            // 
            this.colSSN.Text = "SSN";
            this.colSSN.Width = 150;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarySerializationToolStripMenuItem,
            this.xMLSerializationToolStripMenuItem,
            this.jSONSerializationToolStripMenuItem,
            this.textFileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(815, 25);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // binarySerializationToolStripMenuItem
            // 
            this.binarySerializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeBinary,
            this.btnDeserializeBinary});
            this.binarySerializationToolStripMenuItem.Name = "binarySerializationToolStripMenuItem";
            this.binarySerializationToolStripMenuItem.Size = new System.Drawing.Size(129, 21);
            this.binarySerializationToolStripMenuItem.Text = "Binary Serialization";
            // 
            // btnSerializeBinary
            // 
            this.btnSerializeBinary.Name = "btnSerializeBinary";
            this.btnSerializeBinary.Size = new System.Drawing.Size(180, 22);
            this.btnSerializeBinary.Text = "Serialize";
            this.btnSerializeBinary.Click += new System.EventHandler(this.btnSerializeBinary_Click);
            // 
            // btnDeserializeBinary
            // 
            this.btnDeserializeBinary.Name = "btnDeserializeBinary";
            this.btnDeserializeBinary.Size = new System.Drawing.Size(180, 22);
            this.btnDeserializeBinary.Text = "Deserialize";
            this.btnDeserializeBinary.Click += new System.EventHandler(this.btnDeserializeBinary_Click);
            // 
            // xMLSerializationToolStripMenuItem
            // 
            this.xMLSerializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeXML,
            this.btnDeserializeXML});
            this.xMLSerializationToolStripMenuItem.Name = "xMLSerializationToolStripMenuItem";
            this.xMLSerializationToolStripMenuItem.Size = new System.Drawing.Size(120, 21);
            this.xMLSerializationToolStripMenuItem.Text = "XML Serialization";
            // 
            // btnSerializeXML
            // 
            this.btnSerializeXML.Name = "btnSerializeXML";
            this.btnSerializeXML.Size = new System.Drawing.Size(180, 22);
            this.btnSerializeXML.Text = "Serialize";
            this.btnSerializeXML.Click += new System.EventHandler(this.btnSerializeXML_Click);
            // 
            // btnDeserializeXML
            // 
            this.btnDeserializeXML.Name = "btnDeserializeXML";
            this.btnDeserializeXML.Size = new System.Drawing.Size(180, 22);
            this.btnDeserializeXML.Text = "Deserialize";
            this.btnDeserializeXML.Click += new System.EventHandler(this.btnDeserializeXML_Click);
            // 
            // jSONSerializationToolStripMenuItem
            // 
            this.jSONSerializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeJSON,
            this.btnDeserializeJSON});
            this.jSONSerializationToolStripMenuItem.Name = "jSONSerializationToolStripMenuItem";
            this.jSONSerializationToolStripMenuItem.Size = new System.Drawing.Size(126, 21);
            this.jSONSerializationToolStripMenuItem.Text = "JSON Serialization";
            // 
            // btnSerializeJSON
            // 
            this.btnSerializeJSON.Name = "btnSerializeJSON";
            this.btnSerializeJSON.Size = new System.Drawing.Size(180, 22);
            this.btnSerializeJSON.Text = "Serialize";
            this.btnSerializeJSON.Click += new System.EventHandler(this.btnSerializeJSON_Click);
            // 
            // btnDeserializeJSON
            // 
            this.btnDeserializeJSON.Name = "btnDeserializeJSON";
            this.btnDeserializeJSON.Size = new System.Drawing.Size(180, 22);
            this.btnDeserializeJSON.Text = "Deserialize";
            this.btnDeserializeJSON.Click += new System.EventHandler(this.btnDeserializeJSON_Click);
            // 
            // textFileToolStripMenuItem
            // 
            this.textFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportTextFile});
            this.textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            this.textFileToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.textFileToolStripMenuItem.Text = "TextFile";
            // 
            // btnExportTextFile
            // 
            this.btnExportTextFile.Name = "btnExportTextFile";
            this.btnExportTextFile.Size = new System.Drawing.Size(180, 22);
            this.btnExportTextFile.Text = "Export";
            this.btnExportTextFile.Click += new System.EventHandler(this.btnExportTextFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 537);
            this.Controls.Add(this.lvParticipants);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainForm";
            this.Text = "List View";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSSN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbFemale;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvParticipants;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colBirthDate;
        private System.Windows.Forms.ColumnHeader colGender;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnTile;
        private System.Windows.Forms.Button btnSmallIcon;
        private System.Windows.Forms.Button btnLargeIcon;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.ColumnHeader colSSN;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem binarySerializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeBinary;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeBinary;
        private System.Windows.Forms.ToolStripMenuItem xMLSerializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeXML;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeXML;
        private System.Windows.Forms.ToolStripMenuItem jSONSerializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeJSON;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeJSON;
        private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnExportTextFile;
    }
}

