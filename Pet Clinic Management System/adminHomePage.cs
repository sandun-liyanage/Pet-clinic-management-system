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
    public partial class adminHomePage : Form
    {
        public adminHomePage()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            updateMedicine objupdatemedicine = new updateMedicine();
            objupdatemedicine.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDoctor objadddoc = new addDoctor();
            objadddoc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateDoctor objupdatedoc = new updateDoctor();
            objupdatedoc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctorDetails objdocdetails = new doctorDetails();
            objdocdetails.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteDoctor objdeletedoc = new deleteDoctor();
            objdeletedoc.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            addMedicine objaddmedicine = new addMedicine();
            objaddmedicine.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            medicineDetails objMedicinedetails = new medicineDetails();
            objMedicinedetails.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            deleteMedicine objdeletemedicine = new deleteMedicine();
            objdeletemedicine.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            treatmentHistoryAdmin obj = new treatmentHistoryAdmin();
            obj.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            profitOrLoss objprofitOrLoss = new profitOrLoss();
            objprofitOrLoss.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            petDetails objpetDetails = new petDetails();
            objpetDetails.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            login objlogin = new login();
            objlogin.Show();
            this.Hide();
        }
    }
}
