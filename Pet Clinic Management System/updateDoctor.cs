using System;
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
    public partial class updateDoctor : Form
    {
        public updateDoctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateDoctorPassword objupdatedoctorID = new updateDoctorPassword();
            objupdatedoctorID.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateDoctorName objupdateDoctorName = new updateDoctorName();
            objupdateDoctorName.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateDoctorEmail objupdateDoctorEmail = new updateDoctorEmail();
            objupdateDoctorEmail.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminHomePage objadminHomePage = new adminHomePage();
            objadminHomePage.Show();
            this.Hide();
        }
    }
}
