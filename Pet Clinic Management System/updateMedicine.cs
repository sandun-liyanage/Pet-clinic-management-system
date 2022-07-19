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
    public partial class updateMedicine : Form
    {
        public updateMedicine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateMedicinePrice objupdateMedicinePrice = new updateMedicinePrice();
            objupdateMedicinePrice.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateMedicineName objupdateMedicineName = new updateMedicineName();
            objupdateMedicineName.Show();
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
