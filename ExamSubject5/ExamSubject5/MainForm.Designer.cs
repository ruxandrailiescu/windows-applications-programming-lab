namespace ExamSubject5
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
            this.listViewDoctors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByBirthDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByBirthDateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDoctors
            // 
            this.listViewDoctors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDoctors.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewDoctors.HideSelection = false;
            this.listViewDoctors.Location = new System.Drawing.Point(12, 176);
            this.listViewDoctors.Name = "listViewDoctors";
            this.listViewDoctors.Size = new System.Drawing.Size(628, 255);
            this.listViewDoctors.TabIndex = 0;
            this.listViewDoctors.UseCompatibleStateImageBehavior = false;
            this.listViewDoctors.DoubleClick += new System.EventHandler(this.listViewDoctors_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "BirthDate";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Wage";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Specialty";
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(513, 118);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(127, 39);
            this.btnAddDoctor.TabIndex = 1;
            this.btnAddDoctor.Text = "Add Doctor";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.sortByNameToolStripMenuItem1,
            this.sortByBirthDateToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportXMLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportXMLToolStripMenuItem
            // 
            this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
            this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.exportXMLToolStripMenuItem.Text = "Export XML";
            this.exportXMLToolStripMenuItem.Click += new System.EventHandler(this.exportXMLToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByNameToolStripMenuItem,
            this.sortByBirthDateToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(167, 48);
            // 
            // sortByNameToolStripMenuItem
            // 
            this.sortByNameToolStripMenuItem.Name = "sortByNameToolStripMenuItem";
            this.sortByNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortByNameToolStripMenuItem.Text = "Sort by Name";
            // 
            // sortByBirthDateToolStripMenuItem
            // 
            this.sortByBirthDateToolStripMenuItem.Name = "sortByBirthDateToolStripMenuItem";
            this.sortByBirthDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortByBirthDateToolStripMenuItem.Text = "Sort by Birth Date";
            // 
            // sortByNameToolStripMenuItem1
            // 
            this.sortByNameToolStripMenuItem1.Name = "sortByNameToolStripMenuItem1";
            this.sortByNameToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sortByNameToolStripMenuItem1.Text = "Sort by Name";
            this.sortByNameToolStripMenuItem1.Click += new System.EventHandler(this.sortByNameToolStripMenuItem1_Click);
            // 
            // sortByBirthDateToolStripMenuItem1
            // 
            this.sortByBirthDateToolStripMenuItem1.Name = "sortByBirthDateToolStripMenuItem1";
            this.sortByBirthDateToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sortByBirthDateToolStripMenuItem1.Text = "Sort by Birth Date";
            this.sortByBirthDateToolStripMenuItem1.Click += new System.EventHandler(this.sortByBirthDateToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 443);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.listViewDoctors);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDoctors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportXMLToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sortByNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByBirthDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sortByBirthDateToolStripMenuItem1;
    }
}

