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
    public partial class addPet : Form
    {
        public addPet()
        {
            InitializeComponent();
        }

        private void addPet_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            receptionistHomePage objreceptionistHomePage = new receptionistHomePage();
            objreceptionistHomePage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");

            try
            {
                int ptID = int.Parse(petID.Text);
                string ptName = petName.Text;
                string ptType = type.Text;
                string ptWeight = weight.Text;
                string date = dob.Text;

                int ownrID = int.Parse(ownerID.Text);
                string ownrName = ownerName.Text;
                string phn = contactNum.Text;
                string hsNo = houseNo.Text;
                string st = street.Text;
                string cty = city.Text;

                string petqry = "INSERT INTO pet VALUES(" + ptID + ",'" + ptName + "','" + ptType + "','" + ptWeight + "','" + date + "','" + ownrID + "')";
                string ownerqry = "INSERT INTO owner VALUES(" + ownrID + ",'" + ownrName + "','" + phn + "','" + hsNo + "','" + st + "','" + cty + "');";
                SqlCommand ownercmd = new SqlCommand(ownerqry, con);
                SqlCommand petcmd = new SqlCommand(petqry, con);

                con.Open();
                ownercmd.ExecuteNonQuery();
                petcmd.ExecuteNonQuery();
                MessageBox.Show("data inserted successfully");
            }
            catch (Exception ex)
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

        private void button2_Click(object sender, EventArgs e)
        {
            petID.Text = "";
            petName.Text = "";
            type.Text = "";
            weight.Text = "";
            dob.Text = "";

            ownerID.Text = "";
            ownerName.Text = "";
            contactNum.Text = "";
            houseNo.Text = "";
            street.Text = "";
            city.Text = "";
            
        }
    }
}
