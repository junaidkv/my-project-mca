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
    public partial class editstudent : Form
    {
        dboperation db=new dboperation();
        String passstudent_id;
        public editstudent(String SID)
        {
            InitializeComponent();
            passstudent_id = SID;
        }

        private void editstudent_Load(object sender, EventArgs e)
        {
            
            string dd = "select * from student where student_id ='"+passstudent_id+"'";
            DataTable dt = new DataTable();
            dt = db.exetable(dd);
            textBox1.Text=dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
            //textBox4.Text = passstudent_id;
            textBox3.Text = dt.Rows[0][3].ToString();
            textBox4.Text = dt.Rows[0][0].ToString();
            string dds = "select * from login1 where uname ='" + passstudent_id + "'";
            DataTable dtt = new DataTable();
            dtt = db.exetable(dds);
            textBox5.Text = dtt.Rows[0][1].ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewEditStudent obj = new viewEditStudent();
            obj.Show();
            this.Hide();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string department = textBox2.Text;
            string studentclass = textBox3.Text;



            string username = textBox4.Text;
            string password = textBox5.Text;
            string gg = "update student set student_name='" + name + "' , student_department='" + department + "',student_class='" + studentclass + "',Student_id='" + username + "' where student_id= '" + passstudent_id+"'";
            int ab = db.exenonquery(gg);
            if (ab > 0)
            {
                //Response.Redirect("~/manager/edit.aspx");
                string ggg = "update login1 set uname='" + username + "' , password='" + password + "' where uname = '" + passstudent_id+"'";
                int abb = db.exenonquery(ggg);
                if (abb > 0)
                {
                    MessageBox.Show("updated successfully");
                    viewEditStudent obj = new viewEditStudent();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("updated Failed");
                }
            }
            else
            {
                MessageBox.Show("updated Failed");
            }
        }
    }
}
