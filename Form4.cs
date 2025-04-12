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

namespace CourseWork
{
    public partial class Form4 : Form
    {
        public Form4()
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
            string query = "Insert Into Lendingbooks (txn,date,member_name,book_name,return_date)Values(@txn,@date,@mn,@bn,@rd)";
            //command
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@txn", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@date", this.dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@mn", this.textBox3.Text);
            cmd.Parameters.AddWithValue("@bn", this.comboBox1.Text);
            cmd.Parameters.AddWithValue("@rd", this.dateTimePicker2.Text);


            int rowsaffected = cmd.ExecuteNonQuery();

            if (rowsaffected > 0)
            {
                MessageBox.Show("Leding books details saved successfully");
            }
            else
            {
                MessageBox.Show("Lending books details are not saved");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //connection
            string cs = @"Data Source=LAPTOP-DLHUIALP; Initial Catalog=test; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Query
            string query = "Select max(txn) from Lendingbooks";
            //command
            SqlCommand cmd = new SqlCommand(query, con);

            //check
            string Cid = "";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                string str = dr.GetValue(0).ToString();
                int Ckid = Convert.ToInt32(str.Substring(1));
                Ckid++;

                if (Ckid < 10)
                {
                    Cid = "t00" + Ckid;
                }
                else if (Ckid < 100)
                {
                    Cid = "t0" + Ckid;
                }
                else
                {
                    Cid = "t" + Ckid;
                }

            }
            else
            {
                Cid = "C001";
            }

            this.textBox2.Text = Cid;

        }

    }
}

