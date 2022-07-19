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
    public partial class prescriptionDetails : Form
    {
        public prescriptionDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (pressID.Text != "")
            {
                int prescripID = int.Parse(pressID.Text);
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");
                string qry = "SELECT prescribed_medicine.prescriptionID, medicine.medicineName FROM prescribed_medicine INNER JOIN medicine ON medicine.medicineID = prescribed_medicine.medicineID WHERE prescriptionID = " + prescripID + ";";

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
    }
}
