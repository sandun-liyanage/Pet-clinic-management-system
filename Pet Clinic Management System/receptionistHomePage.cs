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
    public partial class receptionistHomePage : Form
    {
        public receptionistHomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addPet objaddPet = new addPet();
            objaddPet.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login objlogin = new login();
            objlogin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            issueReceipts objissueReceipts = new issueReceipts();
            objissueReceipts.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updatePet objupdatePet = new updatePet();
            objupdatePet.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            petDetails objpetDetails = new petDetails();
            objpetDetails.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            removePet objremovePet = new removePet();
            objremovePet.Show();
            this.Hide();
        }
    }
}
