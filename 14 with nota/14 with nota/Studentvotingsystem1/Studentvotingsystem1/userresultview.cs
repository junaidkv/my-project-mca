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
    public partial class userresultview : Form
    {
        String passuname;
        dboperation db = new dboperation();
        public userresultview(String puname)
        {
            InitializeComponent();
            passuname = puname;
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userhome obj = new Userhome(passuname);
            obj.Show();
            this.Hide();
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProfile obj = new ViewProfile(passuname);
            obj.Show();
            this.Hide();
        }

        private void votingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ddd = "select voting_status from student where student_id='" + passuname + "'";
            SqlConnection connn = new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
            connn.Open();
            SqlCommand cmddd = new SqlCommand(ddd, connn);
            SqlDataReader drnamee = cmddd.ExecuteReader();

            string status = "";
            while (drnamee.Read())
            {
                status = drnamee["voting_status"].ToString();
            }
            if (status == "pending")
            {
                DialogResult d;
                d = MessageBox.Show("Are you sure ? \n An user can enter  voting only for one time", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    voting obj = new voting(passuname);
                    obj.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("your voting is completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userresultview obj = new userresultview(passuname);
            obj.Show();
            this.Hide();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void userresultview_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("hai" + passuname);
            string ddd = "select voting_status from student where voting_status='pending' ";
            SqlConnection connn = new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
            connn.Open();
            SqlCommand cmddd = new SqlCommand(ddd, connn);
            SqlDataReader drnamee = cmddd.ExecuteReader();


            if (drnamee.Read())
            {
                MessageBox.Show("Result Not Published ! \n Not all Student completed their voting", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dataGridView1.Visible = false;
                button1.Visible = false;
                linkLabel2.Visible = false;
            }
            else
            {
                label1.Visible = false;
                
                //button1.Visible = false;
                string dd = "select candidate_id,v.Position_id,p.position_name,c.votes,c.student_id from candidate as c ,viewmaxvote as v inner join position as p on v.position_id=p.position_id where v.position_id=c.position_id and v.mvote=c.votes";
                DataTable dt = new DataTable();
                dt = db.exetable(dd);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
