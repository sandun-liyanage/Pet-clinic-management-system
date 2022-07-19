﻿using System;
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
    public partial class deleteMedicine : Form
    {
        public deleteMedicine()
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
            if (medicineID.Text != "")
            {
                int medID = int.Parse(medicineID.Text);

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");
                string qry = "DELETE FROM medicine WHERE medicineID = " + medID + "; ";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("data deleted successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("data delete error: " + ex.ToString());
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
            medicineID.Text = "";
        }
    }
}