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
    public partial class profitOrLoss : Form
    {
        public profitOrLoss()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminHomePage objadminHomePage = new adminHomePage();
            objadminHomePage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");

            string incomeqry = "SELECT SUM(billAmount) AS income FROM prescription";
            string costqry = "SELECT SUM(cost) AS cost FROM prescription";
            SqlCommand incomecmd = new SqlCommand(incomeqry, con);
            SqlCommand costcmd = new SqlCommand(costqry, con);

            con.Open();
            SqlDataReader sdr1 = incomecmd.ExecuteReader();
            sdr1.Read();
            income.Text = sdr1["income"].ToString();
            income.Visible = true;
            con.Close();

            con.Open();
            SqlDataReader sdr2 = costcmd.ExecuteReader();
            sdr2.Read();
            cost.Text = sdr2["cost"].ToString();
            cost.Visible = true;
            con.Close();

            float incm = float.Parse(income.Text);
            float cst = float.Parse(cost.Text);
            float profit = incm - cst;
            grossProfit.Text = profit.ToString();
            grossProfit.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            income.Text = "";
            cost.Text = "";
            grossProfit.Text = "";
        }
    }
}
