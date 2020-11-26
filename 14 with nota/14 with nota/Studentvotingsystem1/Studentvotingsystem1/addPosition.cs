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
    public partial class addPosition : Form
    {
        dboperation db = new dboperation();
        public addPosition()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string desc = textBox2.Text;
            if (name == "" || desc == "")
            {
                MessageBox.Show("please enter all details");
            }
            else
            {

                string gg = "insert into position values('" + name + "','" + desc + "',0)";

                int ab = db.exenonquery(gg);
                if (ab > 0)
                {
                    MessageBox.Show("Registration successfull");
                    addPosition obj1 = new addPosition();
                    obj1.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Registration unsuccessfull");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                label4.Text = "please enter description";
            }
            else
            {
                label4.Text = "";
            }
        }

        private void label3_Validating(object sender, CancelEventArgs e)
        {

            if (textBox1.Text == "")
            {
                label3.Text = "please enter description";
            }
            else
            {
                label3.Text = "";
            }
        }
    }
}
