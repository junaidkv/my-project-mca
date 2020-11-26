using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Studentvotingsystem1
{
    
    public partial class voting : Form
    {
        dboperation db = new dboperation();
        SqlConnection con=new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
        //SqlCommand cmd;
        SqlDataAdapter adp;
   DataTable dt = new DataTable();
        //int firstindex = -1;
        int lastindex = -1;
        int currentindex = -1;
        string passuname;
        public voting(String puname)
        {
            InitializeComponent();
            lod();
            passuname = puname;
            displaydata();
        }
        private void lod()
        {
            try
            {
                con.Open();
                dt = new DataTable();
                adp = new SqlDataAdapter("select * from position", con);
                adp.Fill(dt);
                //firstindex = 0;
                currentindex = 0;
                lastindex = dt.Rows.Count - 1;

            }
            catch(Exception e)
            {
                MessageBox.Show("error " + e);
            }
        }
        private void displaydata()
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            //DataTable dtt = new DataTable();
            MessageBox.Show("position id " + dt.Rows[currentindex][0],"",MessageBoxButtons.OK,MessageBoxIcon.Information);
            string dd = "select student_id from candidate where position_id="+dt.Rows[currentindex][0];
            db.getcon();
            SqlDataReader dr=db.exereader(dd);
            
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["student_id"].ToString());
                comboBox1.ValueMember=dr["student_id"].ToString();
                comboBox1.DisplayMember = dr["student_id"].ToString();

            }
            db.dbclose();
            label2.Text = dt.Rows[currentindex][1].ToString();
            //db.dbclose();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dd = "select student_name from student where student_id='" +comboBox1.Text+"'";
            SqlConnection conn= new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
            conn.Open();
            SqlCommand cmdd=new SqlCommand(dd,conn);
            SqlDataReader drname = cmdd.ExecuteReader();
            //string sname=new string();
            while (drname.Read())
            {
                label4.Text = drname["student_name"].ToString();
            }
            //label4.Text =sname;
            conn.Close();
            string ddd = "select candidate_photo from candidate where student_id='" + comboBox1.Text + "'";
            SqlConnection connn = new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
            connn.Open();
            SqlCommand cmddd = new SqlCommand(ddd, connn);
            SqlDataReader drnamee = cmddd.ExecuteReader();
            string dirparth = @"C:\Users\jndjk\Documents\Visual Studio 2012\Projects\Studentvotingsystem1\Studentvotingsystem1\candidatephoto";
            string pic="";
            while (drnamee.Read())
            {
               pic= drnamee["candidate_photo"].ToString();
            }
            string imgpath = dirparth + "\\" + pic;
            pictureBox1.Image = Image.FromFile(imgpath);
            connn.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                string notasql = "select nota from position where position_name='" + label2.Text + "'";
                SqlConnection notacon = new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
                notacon.Open();
                SqlCommand notacmd = new SqlCommand(notasql, notacon);
                SqlDataReader notareader = notacmd.ExecuteReader();
                string notanumb = "";
                while (notareader.Read())
                {
                    notanumb = notareader["nota"].ToString();
                }
                notacon.Close();
                int nota = int.Parse(notanumb);
                nota = nota + 1;
                string upnotanum = nota.ToString();
                string notausql = "update position set nota=" + upnotanum + " where position_name='" + label2.Text + "'";
                int i = 0;
                SqlConnection notaucon = new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
                notaucon.Open();
                SqlCommand notaucmdd = new SqlCommand(notausql, notaucon);
                i = notaucmdd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("nota registered");
                    if (currentindex < lastindex)
                    {

                        currentindex = currentindex + 1;
                        displaydata();
                    }
                    else
                    {

                        MessageBox.Show("voting completed");
                        //seting status of user 
                        string votinc = "voting completed";
                        string uvtotestatus = "update student set voting_status='" + votinc + "' where student_id ='" + passuname + "'";
                        int ii = 0;
                        SqlConnection uvtotecon = new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
                        uvtotecon.Open();
                        SqlCommand uvotestatuscmd = new SqlCommand(uvtotestatus, uvtotecon);
                        ii = uvotestatuscmd.ExecuteNonQuery();
                        if (ii > 0)
                        {
                            MessageBox.Show("status updated");
                            Userhome obj = new Userhome(passuname);
                            obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("status not updated");
                        }


                    }
                }
                string dirparthhh = @"C:\Users\jndjk\Documents\Visual Studio 2012\Projects\Studentvotingsystem1\Studentvotingsystem1\candidatephoto";
                string piccc = "default.png";
                string imgpathhh = dirparthhh + "\\" + piccc;
                pictureBox1.Image = Image.FromFile(imgpathhh);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text !="")
            {

                string vsql = "select votes from candidate where student_id='" + comboBox1.Text + "'";
                SqlConnection vcon = new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
                vcon.Open();
                SqlCommand vcmd = new SqlCommand(vsql, vcon);
                SqlDataReader vreader = vcmd.ExecuteReader();
                string pic = "";
                while (vreader.Read())
                {
                    pic = vreader["votes"].ToString();
                }
                vcon.Close();
                int vot = int.Parse(pic);
                vot = vot + 1;
                string uvot = vot.ToString();
                string uvsql = "update candidate set votes=" + uvot + " where student_id ='" + comboBox1.Text + "'";
                int i = 0;
                SqlConnection vucon = new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
                vucon.Open();
                SqlCommand ucmdd = new SqlCommand(uvsql, vucon);
                i = ucmdd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("voted successfully");
                    if (currentindex < lastindex)
                    {

                        currentindex = currentindex + 1;
                        displaydata();
                    }
                    else
                    {
                        MessageBox.Show("voting completed");
                        //seting status of user 
                        string votinc="voting completed";
                        string uvtotestatus = "update student set voting_status='"+votinc+"' where student_id ='" + passuname + "'";
                        int ii = 0;
                        SqlConnection uvtotecon= new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
                        uvtotecon.Open();
                        SqlCommand uvotestatuscmd= new SqlCommand(uvtotestatus, uvtotecon);
                        ii = uvotestatuscmd.ExecuteNonQuery();
                        if (ii > 0)
                        {
                            MessageBox.Show("status updated");
                            Userhome obj = new Userhome(passuname);
                            obj.Show();
                            this.Hide();
                        }
                    else
                    {
                        MessageBox.Show("status not updated");
                     }
                 }
               }
                else
                {
                    MessageBox.Show("voting  unsuccessfull");

                }
                vucon.Close();


            }
            else
            {
                MessageBox.Show("No candidate selected");
            }
            string dirparthh = @"C:\Users\jndjk\Documents\Visual Studio 2012\Projects\Studentvotingsystem1\Studentvotingsystem1\candidatephoto";
            string picc = "default.png";
            string imgpathh = dirparthh + "\\" + picc;
            pictureBox1.Image = Image.FromFile(imgpathh);

        }

        private void voting_FormClosing(object sender, FormClosingEventArgs e)
        {
            string votinc = "voting completed";
            string uvtotestatus = "update student set voting_status='" + votinc + "' where student_id ='" + passuname + "'";
            int ii = 0;
            SqlConnection uvtotecon = new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
            uvtotecon.Open();
            SqlCommand uvotestatuscmd = new SqlCommand(uvtotestatus, uvtotecon);
            ii = uvotestatuscmd.ExecuteNonQuery();
            if (ii > 0)
            {
                MessageBox.Show("Sorry your voting is closed");
                Userhome obj = new Userhome(passuname);
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("error!!!!");
            }

        }

        private void voting_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
