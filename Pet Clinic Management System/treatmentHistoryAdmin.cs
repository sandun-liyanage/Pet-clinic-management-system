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

namespace Pet_Clinic_Management_System
{
    public partial class treatmentHistoryAdmin : Form
    {
        public treatmentHistoryAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");
                string qry = "SELECT * FROM prescription;";

                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataSet ds = new DataSet();

                da.Fill(ds, "prescription");
                dataGridView1.DataSource = ds.Tables["prescription"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminHomePage obj = new adminHomePage();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            prescriptionDetails obj = new prescriptionDetails();
            obj.Show();
        }
    }
}
