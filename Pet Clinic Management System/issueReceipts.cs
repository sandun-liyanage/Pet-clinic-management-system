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
    public partial class issueReceipts : Form
    {
        public issueReceipts()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            receptionistHomePage objreceptionistHomePage = new receptionistHomePage();
            objreceptionistHomePage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(prescriptionID.Text != "")
            {
                int prescripID = int.Parse(prescriptionID.Text);
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");
                
                string qry = "SELECT doctorName FROM doctor WHERE doctorID = (SELECT doctorID from prescription where prescriptionID = " + prescripID + ")";
                SqlCommand cmd = new SqlCommand(qry, con);
                try
                {
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    doctorNamelbl.Text = sdr["doctorName"].ToString();
                    doctorNamelbl.Visible = true;
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }


                qry = "SELECT petName FROM pet WHERE petID = (SELECT petID from prescription where prescriptionID = " + prescripID + ")";
                SqlCommand cmd2 = new SqlCommand(qry, con);
                try
                {
                    con.Open();
                    SqlDataReader sdr = cmd2.ExecuteReader();
                    sdr.Read();
                    petNamelbl.Text = sdr["petName"].ToString();
                    petNamelbl.Visible = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }


                qry = "SELECT date FROM prescription WHERE prescriptionID = " + prescripID + " ";
                SqlCommand cmd3 = new SqlCommand(qry, con);
                try
                {
                    con.Open();
                    SqlDataReader sdr = cmd3.ExecuteReader();
                    sdr.Read();
                    datelbl.Text = sdr["date"].ToString();
                    datelbl.Visible = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }


                prescriptionIDlbl.Text = prescriptionID.ToString();
                prescriptionIDlbl.Visible = true;


                qry = "SELECT billAmount FROM prescription WHERE prescriptionID = " + prescripID + " ";
                SqlCommand cmd4 = new SqlCommand(qry, con);
                try
                {
                    con.Open();
                    SqlDataReader sdr = cmd4.ExecuteReader();
                    sdr.Read();
                    totallbl.Text = sdr["billAmount"].ToString();
                    totallbl.Visible = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("please enter prescription ID");
            }
        }
    }
}
