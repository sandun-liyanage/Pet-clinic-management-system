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
    public partial class updatePet : Form
    {
        public updatePet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            receptionistHomePage objreceptionistHomePage = new receptionistHomePage();
            objreceptionistHomePage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updatePetName objupdatePetName = new updatePetName();
            objupdatePetName.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updatePetType objupdatePetType = new updatePetType();
            objupdatePetType.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updatePetWeight objupdatePetWeight = new updatePetWeight();
            objupdatePetWeight.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updatePetDob objupdatePetDob = new updatePetDob();
            objupdatePetDob.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            updateOwnerName objupdateOwnerName = new updateOwnerName();
            objupdateOwnerName.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateOwnerPhn objupdateOwnerPhn = new updateOwnerPhn();
            objupdateOwnerPhn.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateOwnerAddress objupdateOwnerAddress = new updateOwnerAddress();
            objupdateOwnerAddress.Show();
            this.Hide();
        }
    }
}
