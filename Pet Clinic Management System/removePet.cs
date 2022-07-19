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
    public partial class removePet : Form
    {
        public removePet()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            receptionistHomePage objreceptionistHomePage = new receptionistHomePage();
            objreceptionistHomePage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            petID.Text = "";
            ownerID.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (petID.Text != "")
            {
                int ptID = int.Parse(petID.Text);

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");
                string qry = "DELETE FROM pet WHERE petID = " + ptID + "; ";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data deleted successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("data insert error: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                    receptionistHomePage objreceptionistHomePage = new receptionistHomePage();
                    objreceptionistHomePage.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("please enter required information");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ownerID.Text != "")
            {
                int ownrID = int.Parse(ownerID.Text);

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");
                string qry = "DELETE FROM owner WHERE ownerID = " + ownrID + "; ";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data deleted successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("data insert error: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                    receptionistHomePage objreceptionistHomePage = new receptionistHomePage();
                    objreceptionistHomePage.Show();
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
