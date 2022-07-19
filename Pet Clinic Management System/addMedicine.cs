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
    public partial class addMedicine : Form
    {
        public addMedicine()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminHomePage objadminHomePage = new adminHomePage();
            objadminHomePage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (medicineID.Text!="" || medicineName.Text!="" || price.Text!="")
            {
                int medID = int.Parse(medicineID.Text);
                string medName = medicineName.Text;
                float medCost = float.Parse(price.Text);

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO medicine VALUES(" + medID + ",'" + medName + "'," + medCost + ")";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data inserted successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("data insert error: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                    adminHomePage objadminHomePage = new adminHomePage();
                    objadminHomePage.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("please enter required details");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            medicineID.Text = "";
            medicineName.Text = "";
            price.Text = "";
        }
    }
}
