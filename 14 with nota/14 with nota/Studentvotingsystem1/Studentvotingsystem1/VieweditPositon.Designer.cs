namespace Studentvotingsystem1
{
    partial class VieweditPositon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VieweditPositon));
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
            this.positionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positiondescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.positionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentvotingsystem2DataSet = new Studentvotingsystem1.studentvotingsystem2DataSet();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentvotingsystem1DataSet1 = new Studentvotingsystem1.studentvotingsystem1DataSet1();
            this.positionTableAdapter = new Studentvotingsystem1.studentvotingsystem1DataSet1TableAdapters.positionTableAdapter();
            this.positionTableAdapter1 = new Studentvotingsystem1.studentvotingsystem2DataSetTableAdapters.positionTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem1DataSet1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(845, 28);
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
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionidDataGridViewTextBoxColumn,
            this.positionnameDataGridViewTextBoxColumn,
            this.positiondescriptionDataGridViewTextBoxColumn,
            this.Edit});
            this.dataGridView1.DataSource = this.positionBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(787, 344);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // positionidDataGridViewTextBoxColumn
            // 
            this.positionidDataGridViewTextBoxColumn.DataPropertyName = "position_id";
            this.positionidDataGridViewTextBoxColumn.HeaderText = "position_id";
            this.positionidDataGridViewTextBoxColumn.Name = "positionidDataGridViewTextBoxColumn";
            this.positionidDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionidDataGridViewTextBoxColumn.Width = 101;
            // 
            // positionnameDataGridViewTextBoxColumn
            // 
            this.positionnameDataGridViewTextBoxColumn.DataPropertyName = "position_name";
            this.positionnameDataGridViewTextBoxColumn.HeaderText = "position_name";
            this.positionnameDataGridViewTextBoxColumn.Name = "positionnameDataGridViewTextBoxColumn";
            this.positionnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // positiondescriptionDataGridViewTextBoxColumn
            // 
            this.positiondescriptionDataGridViewTextBoxColumn.DataPropertyName = "position_description";
            this.positiondescriptionDataGridViewTextBoxColumn.HeaderText = "position_description";
            this.positiondescriptionDataGridViewTextBoxColumn.Name = "positiondescriptionDataGridViewTextBoxColumn";
            this.positiondescriptionDataGridViewTextBoxColumn.Width = 159;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 38;
            // 
            // positionBindingSource1
            // 
            this.positionBindingSource1.DataMember = "position";
            this.positionBindingSource1.DataSource = this.studentvotingsystem2DataSet;
            // 
            // studentvotingsystem2DataSet
            // 
            this.studentvotingsystem2DataSet.DataSetName = "studentvotingsystem2DataSet";
            this.studentvotingsystem2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "position";
            this.positionBindingSource.DataSource = this.studentvotingsystem1DataSet1;
            // 
            // studentvotingsystem1DataSet1
            // 
            this.studentvotingsystem1DataSet1.DataSetName = "studentvotingsystem1DataSet1";
            this.studentvotingsystem1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // positionTableAdapter1
            // 
            this.positionTableAdapter1.ClearBeforeFill = true;
            // 
            // VieweditPositon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(845, 449);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VieweditPositon";
            this.Text = "VieweditPositon";
            this.Load += new System.EventHandler(this.VieweditPositon_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem1DataSet1)).EndInit();
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
        private studentvotingsystem1DataSet1 studentvotingsystem1DataSet1;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private studentvotingsystem1DataSet1TableAdapters.positionTableAdapter positionTableAdapter;
        private studentvotingsystem2DataSet studentvotingsystem2DataSet;
        private System.Windows.Forms.BindingSource positionBindingSource1;
        private studentvotingsystem2DataSetTableAdapters.positionTableAdapter positionTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positiondescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
}