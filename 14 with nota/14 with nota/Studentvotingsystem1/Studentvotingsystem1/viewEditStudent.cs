using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentvotingsystem1
{
    public partial class viewEditStudent : Form
    {
        public viewEditStudent()
        {
            InitializeComponent();
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminhome obj = new adminhome();
            obj.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent obj = new AddStudent();
            obj.Show();
            this.Hide();
        }

        private void viewEditStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewEditStudent obj = new viewEditStudent();
            obj.Show();
            this.Hide();
        }

        private void candidateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCandidates obj = new AddCandidates();
            obj.Show();
            this.Hide();

        }

        private void viewEditCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vieweditCandidates obj = new vieweditCandidates();
            obj.Show();
            this.Hide();

        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultReport obj = new ResultReport();
            obj.Show();
            this.Hide();
        }

        private void addPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPosition obj = new addPosition();
            obj.Show();
            this.Hide();
        }

        private void viewEditPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VieweditPositon obj = new VieweditPositon();
            obj.Show();
            this.Hide();
        }

        private void viewEditStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentvotingsystem2DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.studentvotingsystem2DataSet.student);
            // TODO: This line of code loads data into the 'studentvotingsystem1DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentvotingsystem1DataSet.student);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             var sendergrid = (DataGridView)sender;
            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //Form1 obj = new Form1();
                //obj.Show();
                //this.Hide();
                int rowindex = dataGridView1.CurrentCell.RowIndex;

                string passstudent_id = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                if (passstudent_id != "")
                {
                    editstudent obj=new editstudent(passstudent_id);
                    obj.Show();
                    this.Hide();
                }
               }
        }
    }
}
