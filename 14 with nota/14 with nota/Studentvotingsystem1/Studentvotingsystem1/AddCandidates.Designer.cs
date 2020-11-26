namespace Studentvotingsystem1
{
    partial class AddCandidates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCandidates));
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.positionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentvotingsystem2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentvotingsystem2DataSet = new Studentvotingsystem1.studentvotingsystem2DataSet();
            this.studentvotingsystem1DataSet1 = new Studentvotingsystem1.studentvotingsystem1DataSet1();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionTableAdapter = new Studentvotingsystem1.studentvotingsystem1DataSet1TableAdapters.positionTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentvotingsystem2DataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Studentvotingsystem1.studentvotingsystem1DataSet1TableAdapters.studentTableAdapter();
            this.positionTableAdapter1 = new Studentvotingsystem1.studentvotingsystem2DataSetTableAdapters.positionTableAdapter();
            this.studentvotingsystem2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new Studentvotingsystem1.studentvotingsystem2DataSetTableAdapters.studentTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem2DataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem2DataSetBindingSource1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(505, 28);
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.positionBindingSource1;
            this.comboBox1.DisplayMember = "position_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(226, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "position_id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // positionBindingSource1
            // 
            this.positionBindingSource1.DataMember = "position";
            this.positionBindingSource1.DataSource = this.studentvotingsystem2DataSetBindingSource;
            // 
            // studentvotingsystem2DataSetBindingSource
            // 
            this.studentvotingsystem2DataSetBindingSource.DataSource = this.studentvotingsystem2DataSet;
            this.studentvotingsystem2DataSetBindingSource.Position = 0;
            // 
            // studentvotingsystem2DataSet
            // 
            this.studentvotingsystem2DataSet.DataSetName = "studentvotingsystem2DataSet";
            this.studentvotingsystem2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentvotingsystem1DataSet1
            // 
            this.studentvotingsystem1DataSet1.DataSetName = "studentvotingsystem1DataSet1";
            this.studentvotingsystem1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "position";
            this.positionBindingSource.DataSource = this.studentvotingsystem1DataSet1;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Position";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(226, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(170, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox2_Validating);
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.studentvotingsystem2DataSetBindingSource2;
            // 
            // studentvotingsystem2DataSetBindingSource2
            // 
            this.studentvotingsystem2DataSetBindingSource2.DataSource = this.studentvotingsystem2DataSet;
            this.studentvotingsystem2DataSetBindingSource2.Position = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.studentvotingsystem1DataSet1;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // positionTableAdapter1
            // 
            this.positionTableAdapter1.ClearBeforeFill = true;
            // 
            // studentvotingsystem2DataSetBindingSource1
            // 
            this.studentvotingsystem2DataSetBindingSource1.DataSource = this.studentvotingsystem2DataSet;
            this.studentvotingsystem2DataSetBindingSource1.Position = 0;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(292, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 10;
            this.label5.Validating += new System.ComponentModel.CancelEventHandler(this.label5_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(292, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 11;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.Validating += new System.ComponentModel.CancelEventHandler(this.label6_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(265, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(267, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(271, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 14;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AddCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(505, 453);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCandidates";
            this.Text = "AddCandidates";
            this.Load += new System.EventHandler(this.AddCandidates_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem2DataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentvotingsystem2DataSetBindingSource1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private studentvotingsystem1DataSet1 studentvotingsystem1DataSet1;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private studentvotingsystem1DataSet1TableAdapters.positionTableAdapter positionTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private studentvotingsystem1DataSet1TableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource studentvotingsystem2DataSetBindingSource;
        private studentvotingsystem2DataSet studentvotingsystem2DataSet;
        private System.Windows.Forms.BindingSource positionBindingSource1;
        private studentvotingsystem2DataSetTableAdapters.positionTableAdapter positionTableAdapter1;
        private System.Windows.Forms.BindingSource studentvotingsystem2DataSetBindingSource2;
        private System.Windows.Forms.BindingSource studentvotingsystem2DataSetBindingSource1;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private studentvotingsystem2DataSetTableAdapters.studentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}