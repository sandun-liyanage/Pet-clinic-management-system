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
    public partial class treatmentHistory : Form
    {
        public treatmentHistory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctorHomePage obj = new doctorHomePage();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (petID.Text != "")
            {
                int ptID = int.Parse(petID.Text);
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");
                string qry = "SELECT prescriptionID, dosage, date, doctorID, petID FROM prescription WHERE petID = " + ptID + ";";

                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataSet ds = new DataSet();

                da.Fill(ds, "prescription");
                dataGridView1.DataSource = ds.Tables["prescription"];
            }
            else
            {
                MessageBox.Show("please enter required information");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            prescriptionDetails obj = new prescriptionDetails();
            obj.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
