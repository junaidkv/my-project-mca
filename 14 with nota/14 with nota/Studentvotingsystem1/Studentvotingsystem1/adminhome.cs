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
    public partial class adminhome : Form
    {
        public adminhome()
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
    }
}
