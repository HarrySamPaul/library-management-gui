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
    public partial class Form3 : Form
    {
        public Form3()
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
            string query = "Select * from tbluser";
            //command
            SqlDataAdapter dap = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
