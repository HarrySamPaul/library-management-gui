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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork
{
    public partial class Form2 : Form
    {
        string cmb;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string cmbtype)
        {
            InitializeComponent();
            cmb = cmbtype;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "MDI Parent Form";
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmb == "admin")
            {
                Form5 frm5 = new Form5();
                frm5.Show();
                this.Show();
            }
            else
            {
                MessageBox.Show("only admin can access");
            }


        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Show();
        }

        private void addAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Show();
        }

        private void bookLendingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Show();

        }

        private void bookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Show();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Show();
        }

        private void memberLendingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (cmb == "user")
            {
                Form9 frm9 = new Form9();
                frm9.Show();
                this.Show();
            }
            else
            {
                MessageBox.Show("only member can access");
            }
        }
    }
    }
