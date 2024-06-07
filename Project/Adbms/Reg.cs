using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Adbms
{
    public partial class Reg : Form
    {
        private OracleDataAccess oracleDataAccess;

        private DataTable dte=new DataTable();






        public Reg()
        {
            InitializeComponent();
            oracleDataAccess = new OracleDataAccess();
        }







        private void btnLog_Click(object sender, EventArgs e)
        {
            // LoginPage loginPage = new LoginPage();
            // loginPage.Show();

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExitR_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {

                string EmpName = txtEmpName.Text;
                int UserEmpID;//= Convert.ToInt32(txtEmpID.Text) ;
                string EmpPassword = txtEmpPassword.Text;
                int EmpMobileNo;//= Convert.ToInt32(txtMoNo.Text);
                string EmpEmail = txtEmail.Text;
                string EmpAddress = txtAddress.Text;
                int EmpSalary;// = Convert.ToInt32(txtEmpSalary.Text);
                string EmpType = cbxEmpType.Text;




                //Numeric Filed validation
                if (!int.TryParse(txtEmpID.Text, out UserEmpID))// id
                {
                    MessageBox.Show("Employee ID must be Numeric and filed is required*.", "Insert Error");
                    return;
                }

                if (!int.TryParse(txtMoNo.Text, out EmpMobileNo))//mobile num
                {
                    MessageBox.Show("Mobile No must be Numeric and filed is required and length is 11*.", "Insert Error");
                    return;
                }

                if (txtMoNo.Text.Length != 11)
                {

                    MessageBox.Show("Mobile No must be 11 digits .", "Insert Error");



                }

                if (!int.TryParse(txtEmpSalary.Text, out EmpSalary))//salary
                {
                    MessageBox.Show("Salary  must be Numeric and filed is required*.", "Insert Error");
                    return;
                }

                if (EmpSalary < 0)
                {

                    MessageBox.Show("Salary can not be negative*.", "Insert Error");

                }



                //Empty filed validation
                if (string.IsNullOrEmpty(EmpName) || string.IsNullOrEmpty(EmpAddress) || string.IsNullOrEmpty(EmpType) || string.IsNullOrEmpty(dtpJoinDate.Text))
                {
                    MessageBox.Show("Please Filled All the textbox ", "Insert Error");
                    return;
                }



                string insertQuery = "BEGIN insert_employee(" + UserEmpID + ", '" + EmpName + "','" + EmpPassword + "'," + EmpMobileNo + ",'" + EmpEmail + "','" + EmpAddress + "',TO_DATE('" + dtpJoinDate.Text + "', 'DD-MM-YY')," + EmpSalary + ",'" + EmpType + "');END;";


                try
                {
                    int affectedRowsEmp = oracleDataAccess.ExecuteNonQuery(insertQuery);
                    MessageBox.Show("Registration successful!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert operation failed. Error: " + ex.Message, "Insert Error");
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtEmpName.Clear();
            txtMoNo.Clear();
            txtEmpPassword.Clear();
            txtEmpID.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtEmpSalary.Clear();
            txtSearch.Clear();
            cbxEmpType.Text = string.Empty;
            dtpJoinDate.Text = string.Empty;

        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)//Delete
        {

            string deletestring = "BEGIN delete_employee(id => "+txtEmpID.Text+");  END;";


            try
            {
                int affectedRows = oracleDataAccess.ExecuteNonQuery(deletestring);
                MessageBox.Show("Delete successful!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete operation failed. Error: " + ex.Message, "Insert Error");
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)//Update
        {



            try {


                string EmpName = txtEmpName.Text;
                int UserEmpID= Convert.ToInt32(txtEmpID.Text) ;
                string EmpPassword = txtEmpPassword.Text;
                int EmpMobileNo= Convert.ToInt32(txtMoNo.Text);
                string EmpEmail = txtEmail.Text;
                string EmpAddress = txtAddress.Text;
                int EmpSalary = Convert.ToInt32(txtEmpSalary.Text);
                string EmpType = cbxEmpType.Text;


                string update = "BEGIN update_employee(id => " +UserEmpID+ ", name => '"+EmpName+"', pass => '"+EmpPassword+"',mobNo => "+EmpMobileNo+",email =>'"+txtEmail.Text+"',address =>'"+txtAddress.Text+"',joindate => TO_DATE('"+dtpJoinDate.Text+"', 'DD-MM-YY'),salary =>"+EmpSalary+", type => '"+EmpType+"');END;";



                try
                {
                    int affectedRowss = oracleDataAccess.ExecuteNonQuery(update);
                    MessageBox.Show("Update successful!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update operation failed. Error: " + ex.Message, "Insert Error");
                }
            }

            catch { 
            
            
            }



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gridviewEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridviewEmp.SelectedRows.Count > 0)
            {

                txtEmpName.Text = gridviewEmp.SelectedRows[0].Cells["EMP_NAME"].Value.ToString();
                txtEmpID.Text = gridviewEmp.SelectedRows[0].Cells["EMP_ID"].Value.ToString();
                txtEmpPassword.Text = gridviewEmp.SelectedRows[0].Cells["PASSWORD"].Value.ToString();
                txtMoNo.Text = gridviewEmp.SelectedRows[0].Cells["MOB_NO"].Value.ToString();
                txtEmail.Text = gridviewEmp.SelectedRows[0].Cells["EMAIL"].Value.ToString();
                txtAddress.Text = gridviewEmp.SelectedRows[0].Cells["ADDRESS"].Value.ToString();
                dtpJoinDate.Text = gridviewEmp.SelectedRows[0].Cells["JOIN_DATE"].Value.ToString();
                txtEmpSalary.Text = gridviewEmp.SelectedRows[0].Cells["EMP_SALARY"].Value.ToString();
                cbxEmpType.Text = gridviewEmp.SelectedRows[0].Cells["EMP_TYPE"].Value.ToString();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               // int EmpSearch = Convert.ToInt32(txtSearch.Text);
                DataTable empdt = oracleDataAccess.ExecuteQuery("select * from employee order by EMP_ID asc ");

                gridviewEmp.DataSource = empdt;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)//search
        {

            try
            {
                int EmpSearch = Convert.ToInt32(txtSearch.Text);
                DataTable empdt = oracleDataAccess.ExecuteQuery("select * from employee where EMP_ID ="+EmpSearch+"");

                gridviewEmp.DataSource = empdt;

                oracleDataAccess.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void button4_Click(object sender, EventArgs e)//total salary
        {

            string totalAvg = " SELECT * FROM view_total_avg_emp";
            try
            {
                DataTable emptotal = oracleDataAccess.ExecuteQuery(totalAvg);

                gridviewEmp.DataSource = emptotal;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            string maxSal = " SELECT * FROM max_sal_view";
            try
            {
                DataTable empdtt = oracleDataAccess.ExecuteQuery(maxSal);

                gridviewEmp.DataSource = empdtt;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void btnMin_Click(object sender, EventArgs e)
        {

            string minSal = " SELECT * FROM min_sal_view";
            try
            {
                DataTable empmin = oracleDataAccess.ExecuteQuery(minSal);

                gridviewEmp.DataSource = empmin;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void btnSenior_Click(object sender, EventArgs e)
        {
            string senior = " SELECT * FROM senior_view";

            try
            {
                DataTable empSe= oracleDataAccess.ExecuteQuery(senior);

                gridviewEmp.DataSource = empSe;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnJunior_Click(object sender, EventArgs e)
        {
            string junior = " SELECT * FROM junior_view";

            try
            {
                DataTable empJe = oracleDataAccess.ExecuteQuery(junior);

                gridviewEmp.DataSource = empJe;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

