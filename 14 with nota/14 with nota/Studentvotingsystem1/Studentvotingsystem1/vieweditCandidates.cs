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
    public partial class vieweditCandidates : Form
    {
        dboperation db = new dboperation();
        public vieweditCandidates()
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

        private void vieweditCandidates_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentvotingsystem2DataSet.candidate' table. You can move, or remove it, as needed.
            //this.candidateTableAdapter.Fill(this.studentvotingsystem2DataSet.candidate);rin
            string dd = "select candidate.candidate_id,student.student_id,student.student_name,position.position_id,position.position_name,candidate.votes from candidate,student,position where candidate.student_id=student.student_id and position.position_id=candidate.position_id";
           
            DataTable dt = new DataTable();
            dt = db.exetable(dd);
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sendergrid = (DataGridView)sender;
            if (sendergrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                
                int rowindex = dataGridView1.CurrentCell.RowIndex;

                string candid = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                if (candid != "")
                {
                    DialogResult d;
                    d = MessageBox.Show("Delete candidate " + candid, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        string ggg = "delete  from candidate where candidate_id=" + candid;
                        int abb = db.exenonquery(ggg);
                        if (abb > 0)
                        {
                            MessageBox.Show("updated successfully");
                            vieweditCandidates obj = new vieweditCandidates();
                            obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("updated Failed");
                        }
                    }
                }
            }
        }
    }
}
