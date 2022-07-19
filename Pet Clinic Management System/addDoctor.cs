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
    public partial class addDoctor : Form
    {
        public addDoctor()
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
            int docID = int.Parse(doctorID.Text);
            string docName = doctorName.Text;
            string eml = email.Text;
            string pwd = password.Text;

            if (doctorID.Text != "" || password.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO doctor VALUES(" + docID + ",'" + docName + "','" + eml + "','" + pwd + "')";
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
                MessageBox.Show("please enter required information");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctorID.Text = "";
            doctorName.Text = "";
            email.Text = "";
            password.Text = "";
        }
    }
}
