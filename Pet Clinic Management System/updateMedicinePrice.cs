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
    public partial class updateMedicinePrice : Form
    {
        public updateMedicinePrice()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateMedicine obj = new updateMedicine();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (medicineID.Text != "" || price.Text != "")
            {
                int medID = int.Parse(medicineID.Text);
                float medCost = float.Parse(price.Text);

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");
                string qry = "UPDATE medicine SET medCost = " + medCost + " WHERE medicineID = " + medID + "; ";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data updated successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("data update error: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                    updateMedicine obj = new updateMedicine();
                    obj.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("please enter required information");
            }
        }
    }
}
