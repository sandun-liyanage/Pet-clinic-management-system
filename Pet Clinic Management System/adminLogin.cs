﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Clinic_Management_System
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(username.Text == "admin" && password.Text == "admin123")
            {
                adminHomePage obj = new adminHomePage();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid username and password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }
    }
}
