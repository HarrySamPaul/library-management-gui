using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Connection
            string cs = @"Data Source=LAPTOP-DLHUIALP; Initial Catalog=test; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Query 
            string query = "Insert Into Addauthor (aid,name,email)Values(@aid,@name,@email)";
            //command
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@aid", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@name", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@email", this.textBox3.Text);


            int rowsaffected = cmd.ExecuteNonQuery();


            if (rowsaffected > 0)
            {
                MessageBox.Show("Author added successfully");
            }
            else
            {
                MessageBox.Show("Author is not saved");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
