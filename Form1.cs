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

namespace CourseWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Connection
            string cs = @"Data Source=LAPTOP-DLHUIALP; Initial Catalog=test; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Query 
            string query = "Select * from tbluser where uid=@uid AND uname=@uname AND pword=@pword AND utype=@utype";
            //command
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@uid", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@uname", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@pword", this.textBox3.Text);
            cmd.Parameters.AddWithValue("@utype", comboBox1.Text);

            //data reader 
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                Form2 frm2 = new Form2(this.comboBox1.Text);
                frm2.Show();
                this.Show();
            }
            else
            {
                MessageBox.Show("No detail found");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
