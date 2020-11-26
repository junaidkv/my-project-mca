using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentvotingsystem1
{
    public partial class ResultReport : Form
    {
        dboperation db = new dboperation();
        public ResultReport()
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

        private void ResultReport_Load(object sender, EventArgs e)
        {
            string ddd = "select voting_status from student where voting_status='pending' ";
            SqlConnection connn = new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
            connn.Open();
            SqlCommand cmddd = new SqlCommand(ddd, connn);
            SqlDataReader drnamee = cmddd.ExecuteReader();


            if (drnamee.Read())
            {
                MessageBox.Show("Result Not Generated ! \n Not all Student completed their voting", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                dataGridView1.Visible = false;
                button2.Visible = false;
            }
            else
            {
                label1.Visible = false;
                button1.Visible = false;
                string dd = "select candidate_id,v.Position_id,p.position_name,c.votes,c.student_id from candidate as c ,viewmaxvote as v inner join position as p on v.position_id=p.position_id where v.position_id=c.position_id and v.mvote=c.votes";
                DataTable dt = new DataTable();
                dt = db.exetable(dd);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   DialogResult d;
                d = MessageBox.Show("Are you sure ? Result generation will close voting portel", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    dataGridView1.Visible = true;
                    button2.Visible = true;
                    //string str = "select candidate_id,position_id,student_id from candidate where votes in (select max(votes) from candidate group by position_id)";
                    string dd = "select candidate_id,v.Position_id,p.position_name,c.votes,c.student_id from candidate as c ,viewmaxvote as v inner join position as p on v.position_id=p.position_id where v.position_id=c.position_id and v.mvote=c.votes";
                    DataTable dt = new DataTable();
                    dt = db.exetable(dd);
                    dataGridView1.DataSource = dt;
                    //.......udaaayip

                    string votinc = "voting completed";
                            string uvtotestatus = "update student set voting_status='" + votinc + "' ";
                            int ii = 0;
                            SqlConnection uvtotecon = new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
                            uvtotecon.Open();
                            SqlCommand uvotestatuscmd = new SqlCommand(uvtotestatus, uvtotecon);
                            ii = uvotestatuscmd.ExecuteNonQuery();
                            if (ii > 0)
                            {
                                MessageBox.Show("voting panel closed");
                                label1.Visible = false;
                                button1.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("status not updated");
                            }

                    ///.................................................
                    ///
                    //string str = "select candidate_id from candidate where votes in (select max(votes) from candidate group by position_id)";
                    //DataTable dtt = new DataTable();
                    //dtt = db.exetable(str);
                    //DataTable salesData = dtt;

                    //using (SqlConnection sqlconnection = new SqlConnection(@"Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True"))
                    //{
                    //    sqlconnection.Open();


                    //    // Copy the DataTable to SQL Server Table using Table-Valued Parameter
                    //    string sqlInsert = "INSERT INTO [result] SELECT * FROM @SalesHistoryData";
                    //    SqlCommand insertCommand = new SqlCommand(sqlInsert, sqlconnection);
                    //    SqlParameter tvp = insertCommand.Parameters.AddWithValue("@SalesHistoryData", salesData);
                    //    tvp.SqlDbType = SqlDbType.Structured;
                    //    tvp.TypeName = "dbo.SalesHistoryTableType";
                    //    insertCommand.ExecuteNonQuery();
                    //}


                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bmp, 10, 10);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            overall obj = new overall();
            obj.Show();
        }
    }

}
