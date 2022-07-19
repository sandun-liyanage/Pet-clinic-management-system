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
    public partial class doctorlogin : Form
    {
        public doctorlogin()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            int docID = int.Parse(txtusername.Text);
            string pwd = txtpassword.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT COUNT(*) FROM doctor WHERE doctorID=" + docID + " AND password='" + pwd + "'";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                doctorHomePage obj = new doctorHomePage();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid username and password");
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "User Name")
            {
                txtpassword.Text = "";

                txtpassword.ForeColor = Color.Black;
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "User Name";

                txtpassword.ForeColor = Color.Silver;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text == "Password")
            {
                txtusername.Text = "";

                txtusername.ForeColor = Color.Black;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "Password";

                txtusername.ForeColor = Color.Black;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            login fm = new login();
            fm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void doctorlogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpassword.Text = "";
            txtusername.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login objlogin = new login();
            objlogin.Show();
            this.Hide();
        }
    }
}
