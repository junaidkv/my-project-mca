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
    public partial class Form1 : Form
    {
        dboperation db = new dboperation();
        public Form1()
        {
            InitializeComponent();
           // label4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string aa = "select * from login1 where uname='" + username + "' and password='" + password + "'";
            DataTable dt = db.exetable(aa);

            if (dt.Rows.Count > 0)
            {
                String passlid = dt.Rows[0][0].ToString();
                if (dt.Rows[0][2].ToString() == "admin")
                {
                    //MessageBox.Show("login successfull");
                    adminhome obj1 = new adminhome();
                    obj1.Show();
                    this.Hide();
                }
                if (dt.Rows[0][2].ToString() == "student")
                {
                    //MessageBox.Show("login successfull");
                   // MessageBox.Show("welcome" + username);
                    Userhome obj1 = new Userhome(username);
                    obj1.Show();
                    this.Hide();

                }

            }
            else
            {
                MessageBox.Show("login unsuccessfull","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                label4.Text = "please enter username";
            }
            else
            {
                label4.Text = "";
            }
           
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text =="")
            {
                label5.Text = "please enter valid password";
            }
            else
            {
                label5.Text = "";
            }
        }
    }
}
