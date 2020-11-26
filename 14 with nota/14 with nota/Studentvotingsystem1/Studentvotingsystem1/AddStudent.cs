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
    public partial class AddStudent : Form
    {
        dboperation db=new dboperation();
        public AddStudent()
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string department =textBox2.Text;
            string studentclass = textBox3.Text;

            
            
            string username = textBox4.Text;
            string password = textBox5.Text;
            if (name == "" || department == "" || studentclass == "" || username == "" || password == "")
            {
                MessageBox.Show("please enter all details");
            }
            else
            {

                string ff = "insert into login1 values('" + username + "','" + password + "','student')select @@IDENTITY";

                object ob = db.exescalar(ff);

                string gg = "insert into student values('" + username + "','" + name + "','" + department + "','" + studentclass + "','pending')";

                int ab = db.exenonquery(gg);
                if (ab > 0)
                {
                    MessageBox.Show("Registration successfull");
                    AddStudent obj1 = new AddStudent();
                    obj1.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Registration unsuccessfull");
                }
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                label6.Text = "please enter student name";
            }
            else
            {
                label6.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                label7.Text = "please enter student department";
            }
            else
            {
                label7.Text = "";
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == "")
            {
                l8.Text = "please enter student class";
            }
            else
            {
                l8.Text = "";
            }
        }

      

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text == "")
            {
                l9.Text = "please enter student_id";
            }
            else
            {
                l9.Text = "";
            }

        }

       

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5.Text == "")
            {
                label10.Text = "please enter password";
            }
            else
            {
                label10.Text = "";
            }
        }
        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
    
}

