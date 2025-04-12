﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
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
            string query = "Insert Into Addbooks (Book_id,ISBN,Category,Name,Author)Values(@bid,@isbn,@category,@name,@author)";
            //command
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@bid", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@isbn", this.textBox3.Text);
            cmd.Parameters.AddWithValue("@category", this.comboBox2.Text);
            cmd.Parameters.AddWithValue("@name", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@author", this.comboBox1.Text);



            int rowsaffected = cmd.ExecuteNonQuery();

            if (rowsaffected > 0)
            {
                MessageBox.Show("Book saved successfully");
            }
            else
            {
                MessageBox.Show("Book is not saved");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
