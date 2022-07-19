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
    public partial class newTreatment : Form
    {
        public newTreatment()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            doctorHomePage objdoctorHomePage = new doctorHomePage();
            objdoctorHomePage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\sandun\Desktop\Pet Clinic Management System\petClinicDB.mdf';Integrated Security=True;Connect Timeout=30");
            

            int med1 = 0; int med2 = 0; int med3 = 0; float cost = 0;
            if (medicine1.Text != "")
            {
                med1 = int.Parse(medicine1.Text);
                string qry = "SELECT medCost FROM medicine WHERE medicineID = " + med1 + "";
                SqlCommand cmd = new SqlCommand(qry, con);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                string coststringg = sdr["medCost"].ToString();
                cost += float.Parse(coststringg);
                con.Close();
            }
            if (medicine2.Text != "")
            {
                med2 = int.Parse(medicine2.Text);
                string qry = "SELECT medCost FROM medicine WHERE medicineID = " + med2 + "";
                SqlCommand cmd = new SqlCommand(qry, con);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                string coststringg = sdr["medCost"].ToString();
                cost += float.Parse(coststringg);
                con.Close();
            }
            if (medicine3.Text != "")
            {
                med3 = int.Parse(medicine3.Text);
                string qry = "SELECT medCost FROM medicine WHERE medicineID = " + med3 + "";
                SqlCommand cmd = new SqlCommand(qry, con);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                string coststringg = sdr["medCost"].ToString();
                cost += float.Parse(coststringg);
                con.Close();
            }
            string coststring = cost.ToString();

            if(pressID.Text!="" || dosage.Text!="" || doctorID.Text != "" || petID.Text != "" || cost == 0)
            {
                

                try
                {
                    int prescripID = int.Parse(pressID.Text);
                    string dosg = dosage.Text;
                    string dt = date.Text;
                    float bll = 0;
                    if (bill.Text != "")
                        bll = float.Parse(bill.Text);
                    int ptID = int.Parse(petID.Text);
                    int docID = int.Parse(doctorID.Text);


                    string prescripqry = "INSERT INTO prescription VALUES(" + prescripID + ",'" + dosg + "','" + dt + "', " + bll + " , '" + coststring + "' ," + docID + "," + ptID + ");";
                    string medqry1 = "INSERT INTO prescribed_medicine VALUES(" + prescripID + "," + med1 + ");";
                    string medqry2 = "INSERT INTO prescribed_medicine VALUES(" + prescripID + "," + med2 + ");";
                    string medqry3 = "INSERT INTO prescribed_medicine VALUES(" + prescripID + "," + med3 + ");";
                    SqlCommand prescripcmd = new SqlCommand(prescripqry, con);
                    SqlCommand medcmd1 = new SqlCommand(medqry1, con);
                    SqlCommand medcmd2 = new SqlCommand(medqry2, con);
                    SqlCommand medcmd3 = new SqlCommand(medqry3, con);

                    con.Open();
                    prescripcmd.ExecuteNonQuery();
                    if (med1 != 0)
                        medcmd1.ExecuteNonQuery();
                    if (med2 != 0)
                        medcmd2.ExecuteNonQuery();
                    if (med3 != 0)
                        medcmd3.ExecuteNonQuery();
                    MessageBox.Show("data inserted successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("data insert error: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                    doctorHomePage obj = new doctorHomePage();
                    obj.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("please enter required information");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pressID.Text = "";
            dosage.Text = "";
            date.Text = "";
            bill.Text = "";
            doctorID.Text = "";
            petID.Text = "";

            medicine1.Text = "";
            medicine2.Text = "";
            medicine3.Text = "";
        }
    }
}
