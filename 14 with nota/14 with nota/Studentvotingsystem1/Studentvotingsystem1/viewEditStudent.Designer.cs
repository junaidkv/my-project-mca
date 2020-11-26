namespace Studentvotingsystem1
{
    partial class viewEditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewEditStudent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEditStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEditCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEditPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentdepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votingstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentvotingsystem2DataSet = new Studentvotingsystem1.studentvotingsystem2DataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentvotingsystem1DataSet = new Studentvotingsystem1.studentvotingsystem1DataSet();
            this.studentTableAdapter = new Studentvotingsystem1.studentvotingsystem1DataSetTableAdapters.studentTableAdapter();
            this.studentTableAdapter1 = new Studentvotingsystem1.studentvotingsystem2DataSetTableAdapters.studentTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.candidateToolStripMenuItem,
            this.resultToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.viewEditStudentToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // viewEditStudentToolStripMenuItem
            // 
            this.viewEditStudentToolStripMenuItem.Name = "viewEditStudentToolStripMenuItem";
            this.viewEditStudentToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.viewEditStudentToolStripMenuItem.Text = "View/Edit Student";
            this.viewEditStudentToolStripMenuItem.Click += new System.EventHandler(this.viewEditStudentToolStripMenuItem_Click);
            // 
            // candidateToolStripMenuItem
            // 
            this.candidateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCandidateToolStripMenuItem,
            this.viewEditCandidateToolStripMenuItem});
            this.candidateToolStripMenuItem.Name = "candidateToolStripMenuItem";
            this.candidateToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.candidateToolStripMenuItem.Text = "Candidate";
            // 
            // addCandidateToolStripMenuItem
            // 
            this.addCandidateToolStripMenuItem.Name = "addCandidateToolStripMenuItem";
            this.addCandidateToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.addCandidateToolStripMenuItem.Text = "Add Candidate";
            this.addCandidateToolStripMenuItem.Click += new System.EventHandler(this.addCandidateToolStripMenuItem_Click);
            // 
            // viewEditCandidateToolStripMenuItem
            // 
            this.viewEditCandidateToolStripMenuItem.Name = "viewEditCandidateToolStripMenuItem";
            this.viewEditCandidateToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.viewEditCandidateToolStripMenuItem.Text = "View/Edit Candidate";
            this.viewEditCandidateToolStripMenuItem.Click += new System.EventHandler(this.viewEditCandidateToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resultToolStripMenuItem.Image")));
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.resultToolStripMenuItem.Text = "Result";
            this.resultToolStripMenuItem.Click += new System.EventHandler(this.resultToolStripMenuItem_Click);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPositionToolStripMenuItem,
            this.viewEditPositionToolStripMenuItem});
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.positionToolStripMenuItem.Text = "Position";
            // 
            // addPositionToolStripMenuItem
            // 
            this.addPositionToolStripMenuItem.Name = "addPositionToolStripMenuItem";
            this.addPositionToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.addPositionToolStripMenuItem.Text = "Add Position";
            this.addPositionToolStripMenuItem.Click += new System.EventHandler(this.addPositionToolStripMenuItem_Click);
            // 
            // viewEditPositionToolStripMenuItem
            // 
            this.viewEditPositionToolStripMenuItem.Name = "viewEditPositionToolStripMenuItem";
            this.viewEditPositionToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.viewEditPositionToolStripMenuItem.Text = "View/Edit Position";
            this.viewEditPositionToolStripMenuItem.Click += new System.EventHandler(this.viewEditPositionToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentidDataGridViewTextBoxColumn,
            this.studentnameDataGridViewTextBoxColumn,
            this.studentdepartmentDataGridViewTextBoxColumn,
            this.studentclassDataGridViewTextBoxColumn,
            this.votingstatusDataGridViewTextBoxColumn,
            this.Edit});
            this.dataGridView1.DataSource = this.studentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 316);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "student_name";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "student_name";
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            // 
            // studentdepartmentDataGridViewTextBoxColumn
            // 
            this.studentdepartmentDataGridViewTextBoxColumn.DataPropertyName = "student_department";
            this.studentdepartmentDataGridViewTextBoxColumn.HeaderText = "student_department";
            this.studentdepartmentDataGridViewTextBoxColumn.Name = "studentdepartmentDataGridViewTextBoxColumn";
            // 
            // studentclassDataGridViewTextBoxColumn
            // 
            this.studentclassDataGridViewTextBoxColumn.DataPropertyName = "student_class";
            this.studentclassDataGridViewTextBoxColumn.HeaderText = "student_class";
            this.studentclassDataGridViewTextBoxColumn.Name = "studentclassDataGridViewTextBoxColumn";
            // 
            // votingstatusDataGridViewTextBoxColumn
            // 
            this.votingstatusDataGridViewTextBoxColumn.DataPropertyName = "voting_status";
            this.votingstatusDataGridViewTextBoxColumn.HeaderText = "voting_status";
            this.votingstatusDataGridViewTextBoxColumn.Name = "votingstatusDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.studentvotingsystem2DataSet;
            // 
            // studentvotingsystem2DataSet
            // 
            this.studentvotingsystem2DataSet.DataSetName = "studentvotingsystem2DataSet";
            this.studentvotingsystem2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.studentvotingsystem1DataSet;
            // 
            // studentvotingsystem1DataSet
            // 
            this.studentvotingsystem1DataSet.DataSetName = "studentvotingsystem1DataSet";
            this.studentvotingsystem1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // viewEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(897, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "viewEditStudent";
            this.Text = "viewEditStudent";
            this.Load += new System.EventHandler(this.viewEditStudent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEditStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCandidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEditCandidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEditPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private studentvotingsystem1DataSet studentvotingsystem1DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private studentvotingsystem1DataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private studentvotingsystem2DataSet studentvotingsystem2DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private studentvotingsystem2DataSetTableAdapters.studentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentdepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn votingstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}