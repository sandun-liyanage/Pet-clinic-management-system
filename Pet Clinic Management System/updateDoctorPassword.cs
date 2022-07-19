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
    public partial class updateDoctorPassword : Form
    {
        public updateDoctorPassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateDoctor obj = new updateDoctor();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (doctorID.Text != "" || password.Text != "")
            {
                int docID = int.Parse(doctorID.Text);
                string pwd = password.Text;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");
                string qry = "UPDATE doctor SET password = '" + pwd + "' WHERE doctorID = " + docID + "; ";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data updated successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("data insert error: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                    updateDoctor obj = new updateDoctor();
                    obj.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("please enter required information");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doctorID.Text = "";
            password.Text = "";
        }
    }
}
