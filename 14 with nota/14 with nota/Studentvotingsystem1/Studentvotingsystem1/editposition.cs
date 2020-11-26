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
    public partial class editposition : Form
    {
        dboperation db = new dboperation();
        String passpid;
        public editposition(String pid)
        {
            InitializeComponent();
            passpid = pid;
        }

        private void editposition_Load(object sender, EventArgs e)
        {
            string dd = "select * from position where position_id ="+passpid;
            DataTable dt = new DataTable();
            dt = db.exetable(dd);
            textBox1.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VieweditPositon obj = new VieweditPositon();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pname = textBox1.Text;
            string pdesc = textBox2.Text;

            string ggg = "update position set position_name='" + pname + "' , position_description='" + pdesc + "' where position_id = " +passpid ;
                int abb = db.exenonquery(ggg);
                if (abb > 0)
                {
                    MessageBox.Show("updated successfully");
                    VieweditPositon obj = new VieweditPositon();
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
