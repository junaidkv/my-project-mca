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
    public partial class ViewProfile : Form
    {
        String passuname;
        dboperation db = new dboperation();
        public ViewProfile(String puname)
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

        private void ViewProfile_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("hai " + passuname);
            string dd = "select * from student where student_id ='" + passuname + "'";
            DataTable dt = new DataTable();
            dt = db.exetable(dd);
            label5.Text = dt.Rows[0][0].ToString();
            label6.Text = dt.Rows[0][1].ToString();
            //textBox4.Text = passstudent_id;
            label7.Text = dt.Rows[0][2].ToString();
            label8.Text = dt.Rows[0][3].ToString();
            label10.Text = dt.Rows[0][4].ToString();
        }
    }
}
