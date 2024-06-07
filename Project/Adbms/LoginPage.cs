using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Adbms
{
    public partial class LoginPage : Form
    {
        private OracleDataAccess oracleDataAccess;
      
        public LoginPage()
        {
            InitializeComponent();
            oracleDataAccess = new OracleDataAccess();


        }

        private void btnDB_Click(object sender, EventArgs e)
        {


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {



            try
            {


                int sid = Convert.ToInt32(txtID.Text);
                string password = txtPass.Text;



                if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    MessageBox.Show("Please enter values for all fields.", "Insert Error");
                    return;
                }

                if (txtPass.Text.Length != 4)
                {

                    MessageBox.Show("Password Length must be 4 ", "Insert Error");

                }
                //loginnnn


                string sqlLoginAdmin = "select COUNT(*)  from admin where USERID=" + sid + " and PASSWORD='" + password + "'";
                string sqlLoginEmp = "SELECT COUNT(*)  FROM employee where EMP_ID=" + sid + " and PASSWORD='" + password + "'";

                int AdminCount = Convert.ToInt32(oracleDataAccess.ExecuteScalar(sqlLoginAdmin));
                int EmpCount = Convert.ToInt32(oracleDataAccess.ExecuteScalar(sqlLoginEmp));


                if (AdminCount > 0)
                {
                    MessageBox.Show(" Admin Login successfully!", "Success");

                    // Redirect to your main form or perform other actions
                    AdminInterFace ai = new AdminInterFace();
                    ai.Show();
                    this.Hide();
                }

                else if (EmpCount > 0)
                {
                    MessageBox.Show("Employee Login successfully!", "Success");

                    // Redirect to your main form or perform other actions

                   PatientInfo pp = new PatientInfo();
                    pp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed. Please try again.", "Login Error");
                }

                    


                

                /*
                // Employee Login
                string sqlLoginEmp = "SELECT COUNT(*) FROM employee WHERE EMP_ID=" + sid + " AND PASSWORD='" + password + "'";

                using (OracleConnection connection = new OracleConnection("User Id=system;Password=tiger;Data Source=//localhost:1521/XE"))
                using (OracleCommand command = new OracleCommand(sqlLoginEmp, connection))
                {
                    connection.Open();

                    int empCount = Convert.ToInt32(command.ExecuteScalar());

                    if (empCount > 0)
                    {
                        MessageBox.Show("Employee login successfully!", "Success");

                        Reg reg = new Reg();
                        reg.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Employee login failed. Please try again.", "Login Error");
                    }
                }
                
                // Admin Login
                string sqlLoginAdmin = "SELECT COUNT(*) FROM admin WHERE USERID=" + sid + " AND PASSWORD='" + password + "'";

                using (OracleConnection connection = new OracleConnection("User Id=system;Password=tiger;Data Source=//localhost:1521/XE"))
                using (OracleCommand command = new OracleCommand(sqlLoginAdmin, connection))
                {
                    connection.Open();

                    int adminCount = Convert.ToInt32(command.ExecuteScalar());

                    if (adminCount > 0)
                    {
                        MessageBox.Show("Admin login successfully!", "Success");

                        AdminInterFace ai = new AdminInterFace();
                        ai.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Admin login failed. Please try again.", "Login Error");
                    }
                }



                */


            }





            catch (Exception exp)
            {

                MessageBox.Show("Error: " + exp.Message, "Error");

            }   





          }

          private void txtID_TextChanged(object sender, EventArgs e)
          {

          }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                txtPass.UseSystemPasswordChar = false;
            }

            else
            {
                txtPass.UseSystemPasswordChar = true;



            }
        }
    }
    }

