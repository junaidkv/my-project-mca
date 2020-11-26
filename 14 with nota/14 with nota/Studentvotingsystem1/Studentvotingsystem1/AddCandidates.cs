using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Studentvotingsystem1
{
    public partial class AddCandidates : Form
    {
        dboperation db = new dboperation();
        public AddCandidates()
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

        private void AddCandidates_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentvotingsystem2DataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.studentvotingsystem2DataSet.student);
            // TODO: This line of code loads data into the 'studentvotingsystem2DataSet.position' table. You can move, or remove it, as needed.
            this.positionTableAdapter1.Fill(this.studentvotingsystem2DataSet.position);
            // TODO: This line of code loads data into the 'studentvotingsystem1DataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentvotingsystem1DataSet1.student);
            // TODO: This line of code loads data into the 'studentvotingsystem1DataSet1.position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this.studentvotingsystem1DataSet1.position);
           //DataTable dt1= db.exetable("select position_id from position");
           //comboBox1.DataSource = dt1;

              // comboBox1. = txt;
            //    ddl.DataValueField = val;
            //    ddl.DataSource = exedataset(sql);
            //    ddl.DataBind();
            //    ddl.Items.Insert(0, new ListItem("........select.......", "0"));
            comboBox2.Items.Clear();
            SqlConnection cc = new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
            cc.Open();
            string ddd = "select student.student_id from student where student_id not in (select candidate.student_id from candidate)";
            SqlCommand cm = new SqlCommand(ddd, cc);
            SqlDataReader drr = cm.ExecuteReader();
            while (drr.Read())
            {
                comboBox2.Items.Add(drr["student_id"].ToString());
                comboBox2.ValueMember = drr["student_id"].ToString();
                comboBox2.DisplayMember = drr["student_id"].ToString();
            }
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string posid = comboBox1.Text;
            string posid = comboBox1.SelectedValue.ToString();
            string sid = comboBox2.Text;
            //MessageBox.Show(comboBox1.SelectedValue.ToString());
            if (posid == "" || sid == "")
            {
                MessageBox.Show(" please enter the details");
            }
            else
            {

                string dd = "select * from candidate where student_id ='" + sid + "'";
                DataTable dt = new DataTable();
                dt = db.exetable(dd);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This student is not eligible");
                }
                else
                {

                    DialogResult result = openFileDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {

                        string file = openFileDialog1.FileName;
                        string[] f = file.Split('\\');
                        string fn = f[(f.Length) - 1];
                        string dest = @"C:\Users\jndjk\Documents\Visual Studio 2012\Projects\Studentvotingsystem1\Studentvotingsystem1\candidatephoto\" + fn;
                        File.Copy(file, dest, true);
                        int vote = 0;
                        string sql = "insert into candidate values('" + fn + "','" + sid + "'," + posid + "," + vote + ")";
                        int ab = db.exenonquery(sql);
                        if (ab > 0)
                        {
                            MessageBox.Show("Registration successfull");
                            AddCandidates obj1 = new AddCandidates();
                            obj1.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Registration unsuccessfull");
                        }
                    }
                }
            }
        }

        private void label5_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void label6_Validating(object sender, CancelEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.Text == "")
            {
                label5.Text = "please select position";
            }
            else
            {
                label5.Text = "";
            }
        }

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox2.Text == "")
            {
                label6.Text = "please select candidate";
            }
            else
            {
                label6.Text = "";
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter1.FillBy(this.studentvotingsystem2DataSet.student);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dddd = "select * from student where student_id='" + comboBox2.Text + "'";
            SqlConnection connn = new SqlConnection("Data Source=.;Initial Catalog=studentvotingsystem2;Integrated Security=True");
            connn.Open();
            SqlCommand cmdd = new SqlCommand(dddd, connn);
            SqlDataReader drname = cmdd.ExecuteReader();
            //string sname=new string();
            while (drname.Read())
            {
                label1.Text = drname["student_name"].ToString();
                label4.Text = drname["student_department"].ToString();
                label7.Text = drname["student_class"].ToString();
            }
            //label4.Text =sname;
            connn.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
