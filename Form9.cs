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
   
    public partial class Form9 : Form
    {
       
        public Form9()
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
            string query = "Select * from Lendingbooks where txn=@txn";
            //command
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@txn", this.textBox1.Text);

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            CrystalReport3 rpt = new CrystalReport3();
            rpt.Load("C:\\Users\\HARRY\\Desktop\\FolderCR\\CourseWork\\CourseWork\\CrystalReport3.rpt");
            rpt.SetDataSource(ds.Tables[0]);
            this.crystalReportViewer1.ReportSource = rpt;


        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = "C:\\Users\\HARRY\\Desktop\\FolderCR\\CourseWork\\CourseWork\\CrystalReport3.rpt";
        }
    }
}
