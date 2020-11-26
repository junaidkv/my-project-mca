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
    
    public partial class overall : Form
    {
        dboperation db = new dboperation();
        public overall()
        {
            InitializeComponent();
        }

        private void overall_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentvotingsystem2DataSet1.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.studentvotingsystem2DataSet1.candidate);
            DataTable dt = new DataTable();
            string dd = "select position_name,candidate_id,candidate.student_id,student.student_name,votes from candidate inner join student on candidate.student_id=student.student_id inner join  position on candidate.position_id=position.position_id order by position_name";
            dt = db.exetable(dd);
            dataGridView1.DataSource = dt;
            DataTable dtt = new DataTable();
            string ddd = "select position_id,position_name,nota from position";
            dtt = db.exetable(ddd);
            dataGridView2.DataSource = dtt;

        }
    }
}
