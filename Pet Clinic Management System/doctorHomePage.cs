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
    public partial class doctorHomePage : Form
    {
        public doctorHomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newTreatment objnewTreatment = new newTreatment();
            objnewTreatment.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treatmentHistory objtreatmentHistory = new treatmentHistory();
            objtreatmentHistory.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            petDetails objpetDetails = new petDetails();
            objpetDetails.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login objlogin = new login();
            objlogin.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
