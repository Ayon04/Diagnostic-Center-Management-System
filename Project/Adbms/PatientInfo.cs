using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adbms
{
    public partial class PatientInfo : Form
    {
        private OracleDataAccess oracleDataAccess;
        public PatientInfo()
        {
            InitializeComponent();
            oracleDataAccess = new OracleDataAccess();
            GenerateAutoId();

        }

        private void PatientInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientID.Clear();
            txtPatientName.Clear();
            txtPatientAddress.Clear();
            txtPhone.Clear();
            txtPatientAge.Clear();
            txtSearch.Clear();
            txtTotalAmount.Clear();
            txtDiscount.Clear();
            txtNetTotal.Clear();
            cbxReference.Text = string.Empty;
            cbxTest.Text = string.Empty;
            cbcGender.Text = string.Empty;
            DtpTest.Text = string.Empty;
        }








        private void btnInsert_Click(object sender, EventArgs e)
        {
            GenerateAutoId();



            try
            {

                int patientId;

                string PatientName = txtPatientName.Text;
                string Referenece = cbxReference.Text;
                string gender = cbcGender.Text;
                string addresds = txtPatientAddress.Text;

          

                int age;
                int phoneNo;
                string test = cbxTest.Text;
                int totalAmont=0;//=Convert.ToInt32(txtTotalAmount.Text);
                int discount;
                int netTotal=0;//=Convert.ToInt32(txtNetTotal.Text);
                string date = DtpTest.Text;

                



                int distotal;







                //Numeric Filed validation
                if (!int.TryParse(txtPatientID.Text, out patientId))// id
                {
                    MessageBox.Show("Employee ID must be Numeric and filed is required*.", "Insert Error");
                    return;
                }

                if (!int.TryParse(txtPatientAge.Text, out age))// age
                {
                    MessageBox.Show("Age must be Numeric and filed is required*.", "Insert Error");
                    return;
                }
                age = Convert.ToInt32(txtPatientAge.Text);
                if (age <= 0 || txtPatientAge.Text.Length > 3)
                {

                    MessageBox.Show("Age filed contains wronge value.", "Insert Error");


                }

                if (!int.TryParse(txtPhone.Text, out phoneNo))// phn no
                {
                    MessageBox.Show("Phone No must be Numeric and filed is required*.", "Insert Error");
                    return;
                }

                if (txtPhone.Text.Length != 11)
                {
                    MessageBox.Show("Phone No must be 11 digits.", "Insert Error");

                }


                if (string.IsNullOrEmpty(PatientName) || string.IsNullOrEmpty(Referenece)
                    || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(addresds)
                    || string.IsNullOrEmpty(test))
                {
                    MessageBox.Show("Please Filled All the textbox ", "Insert Error");
                    return;
                }

                if (cbxTest.SelectedItem.ToString() == "CBC ")
                {
                    totalAmont = 400;
                    txtTotalAmount.Text = totalAmont.ToString();


                }


                if (cbxTest.SelectedItem.ToString() == "MRI")
                {
                    totalAmont = 4500;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "CT-SCAN ")
                {
                    totalAmont = 3500;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "DENGHUE (NSI)")
                {
                    totalAmont = 350;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "URIN TEST")
                {
                    totalAmont = 250;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "COLONOSCOPY")
                {
                    totalAmont = 6000;
                    txtTotalAmount.Text = totalAmont.ToString();


                }


                if (cbxTest.SelectedItem.ToString() == "ANDOSCOPY ")
                {
                    totalAmont = 3500;
                    txtTotalAmount.Text = totalAmont.ToString();


                }


                if (cbxTest.SelectedItem.ToString() == "BLOOD GROUP")
                {
                    totalAmont = 200;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "BLOOD SUGER ")
                {
                    totalAmont = 150;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "X- RAY ")
                {
                    totalAmont = 1200;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "ECG")
                {
                    totalAmont = 1500;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "ETT")
                {
                    totalAmont = 1800;
                    txtTotalAmount.Text = totalAmont.ToString();


                }


                if (cbxTest.SelectedItem.ToString() == "ENGIOGRAM ")
                {
                    totalAmont = 2000;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "ULTRASONOGRAPHY")
                {
                    totalAmont = 1300;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (!int.TryParse(txtDiscount.Text, out discount))// discount
                {
                    MessageBox.Show("Discount is numeric filed and required.", "Insert Error");
                    return;
                }



                //  discount = Convert.ToInt32(txtDiscount.Text);

                if (txtDiscount.Text != null && discount <= 100 && discount >= 0)
                {



                  //  totalAmont = Convert.ToInt32(txtTotalAmount.Text);
                    discount = Convert.ToInt32(txtDiscount.Text);
                    distotal = (totalAmont * discount) / 100;
                    netTotal = totalAmont - distotal;
                    //netTotal = totalAmont * discount / 100;
                    // netTotal=to


                    txtNetTotal.Text = netTotal.ToString();
                    //txtNetTotal.Text = "sdsd".ToString();



                }

                else
                {

                    MessageBox.Show("Discount Filed is contain wrong value OR empty", "Insert Error");

                }



                string insert = "BEGIN insert_patient("+patientId+", '"+PatientName+"', '"+Referenece+"', '"+gender+"', '"+addresds+"',"+age+", "+phoneNo+", '"+test+"',"+totalAmont+","+discount+","+netTotal+", TO_DATE('"+date+"', 'DD-MM-YY'));END;";

                try
                {
                    int affectedRowsss = oracleDataAccess.ExecuteNonQuery(insert);
                    MessageBox.Show("insert successful!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("insert operation failed. Error: " + ex.Message, "Insert Error");
                }







            }

            catch
            {





            }






        }

        private int nextId = 1;  // Starting value for ID

        public void GenerateAutoId()
        {

            string countQuery = "SELECT COUNT(PATIENTID) FROM patient";
            int count = Convert.ToInt32(oracleDataAccess.ExecuteScalar(countQuery));

            int nextId = count + 1;

            txtPatientID.Text = nextId.ToString();
        }










        private void btnLoad_Click(object sender, EventArgs e)
        {
            


            try
            {
                DataTable empdt = oracleDataAccess.ExecuteQuery("SELECT * FROM patient order by patientid asc ");

                dgvPatientsInfo.DataSource = empdt;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text += "***********PATIENTS BILLING INFORMATION***********";
            txtResult.Text += "\n----------------------------------------------------------------------";
            txtResult.Text += "\nPatient ID           : " + txtPatientID.Text + "";
            txtResult.Text += "\nPatient Name     : " + txtPatientName.Text + "";
            txtResult.Text += "\nReference: " + cbxReference.Text + "";
            txtResult.Text += "\nGender: " + cbcGender.Text + "";
            txtResult.Text += "\nAddress: " + txtPatientAddress.Text + "";
            txtResult.Text += "\nPatient Age: " + txtPatientAge.Text + " Year(s)";
            txtResult.Text += "\nPhone No: " + txtPhone.Text + "";
            txtResult.Text += "\nTest: " + cbxTest.Text + "";
            txtResult.Text += "\nTotal Amount: " + txtTotalAmount.Text + " TK";
            txtResult.Text += "\nDiscount: " + txtDiscount.Text + " %";
            txtResult.Text += "\nNet Total: " + txtNetTotal.Text + " TK";
            txtResult.Text += "\nDate of Test: " + DtpTest.Text + "";
            txtResult.Text += "\n                                                      " +
                "            Signature ";








        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {



            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)//delete
        {


            string deletePatient = "BEGIN delete_patient(id => "+txtPatientID.Text+"); END;";


            try
            {
                int affectedRoww = oracleDataAccess.ExecuteNonQuery(deletePatient);
                MessageBox.Show("Delete successful!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete operation failed. Error: " + ex.Message, "Delete Error");
            }



        }

        private void dgvPatientsInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPatientsInfo.SelectedRows.Count > 0)
            {

                txtPatientID.Text = dgvPatientsInfo.SelectedRows[0].Cells["PATIENTID"].Value.ToString();
                txtPatientName.Text = dgvPatientsInfo.SelectedRows[0].Cells["PATIENTNAME"].Value.ToString();
                cbxReference.Text = dgvPatientsInfo.SelectedRows[0].Cells["REFERENCE"].Value.ToString();
                cbcGender.Text =dgvPatientsInfo.SelectedRows[0].Cells["GENDER"].Value.ToString();
                txtPatientAddress.Text = dgvPatientsInfo.SelectedRows[0].Cells["ADDRESS"].Value.ToString();
                txtPatientAge.Text = dgvPatientsInfo.SelectedRows[0].Cells["AGE"].Value.ToString();
                txtPhone.Text = dgvPatientsInfo.SelectedRows[0].Cells["PHONENO"].Value.ToString();
                cbxTest.Text = dgvPatientsInfo.SelectedRows[0].Cells["TEST"].Value.ToString();
                txtTotalAmount.Text = dgvPatientsInfo.SelectedRows[0].Cells["TOTAL"].Value.ToString();
                txtDiscount.Text = dgvPatientsInfo.SelectedRows[0].Cells["DISCOUNT"].Value.ToString();
                txtNetTotal.Text = dgvPatientsInfo.SelectedRows[0].Cells["NETTOTAL"].Value.ToString();

                DtpTest.Text= dgvPatientsInfo.SelectedRows[0].Cells["TESTDATE"].Value.ToString();




            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int PatientSearch = Convert.ToInt32(txtSearch.Text);
                DataTable empdt = oracleDataAccess.ExecuteQuery("select * from patient where PATIENTID =" + PatientSearch + "");

                dgvPatientsInfo.DataSource = empdt;

                oracleDataAccess.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            try
            {

                int patientId;

                string PatientName = txtPatientName.Text;
                string Referenece = cbxReference.Text;
                string gender = cbcGender.Text;
                string addresds = txtPatientAddress.Text;
                int age;
                int phoneNo;
                string test = cbxTest.Text;
                int totalAmont = 0;//=Convert.ToInt32(txtTotalAmount.Text);
                int discount;
                int netTotal = 0;//=Convert.ToInt32(txtNetTotal.Text);
                string date = DtpTest.Text;


                int distotal;







                //Numeric Filed validation
                if (!int.TryParse(txtPatientID.Text, out patientId))// id
                {
                    MessageBox.Show("Employee ID must be Numeric and filed is required*.", "Insert Error");
                    return;
                }

                if (!int.TryParse(txtPatientAge.Text, out age))// age
                {
                    MessageBox.Show("Age must be Numeric and filed is required*.", "Insert Error");
                    return;
                }
                age = Convert.ToInt32(txtPatientAge.Text);
                if (age <= 0 || txtPatientAge.Text.Length > 3)
                {

                    MessageBox.Show("Age filed contains wronge value.", "Insert Error");


                }

                if (!int.TryParse(txtPhone.Text, out phoneNo))// phn no
                {
                    MessageBox.Show("Phone No must be Numeric and filed is required*.", "Insert Error");
                    return;
                }

                if (txtPhone.Text.Length != 11)
                {
                    MessageBox.Show("Phone No must be 11 digits.", "Insert Error");

                }


                if (string.IsNullOrEmpty(PatientName) || string.IsNullOrEmpty(Referenece)
                    || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(addresds)
                    || string.IsNullOrEmpty(test))
                {
                    MessageBox.Show("Please Filled All the textbox ", "Insert Error");
                    return;
                }

                if (cbxTest.SelectedItem.ToString() == "CBC ")
                {
                    totalAmont = 400;
                    txtTotalAmount.Text = totalAmont.ToString();


                }


                if (cbxTest.SelectedItem.ToString() == "MRI")
                {
                    totalAmont = 4500;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "CT-SCAN ")
                {
                    totalAmont = 3500;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "DENGHUE (NSI)")
                {
                    totalAmont = 350;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "URIN TEST")
                {
                    totalAmont = 250;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "COLONOSCOPY")
                {
                    totalAmont = 6000;
                    txtTotalAmount.Text = totalAmont.ToString();


                }


                if (cbxTest.SelectedItem.ToString() == "ANDOSCOPY ")
                {
                    totalAmont = 3500;
                    txtTotalAmount.Text = totalAmont.ToString();


                }


                if (cbxTest.SelectedItem.ToString() == "BLOOD GROUP")
                {
                    totalAmont = 200;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "BLOOD SUGER ")
                {
                    totalAmont = 150;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "X- RAY ")
                {
                    totalAmont = 1200;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "ECG")
                {
                    totalAmont = 1500;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "ETT")
                {
                    totalAmont = 1800;
                    txtTotalAmount.Text = totalAmont.ToString();


                }


                if (cbxTest.SelectedItem.ToString() == "ENGIOGRAM ")
                {
                    totalAmont = 2000;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (cbxTest.SelectedItem.ToString() == "ULTRASONOGRAPHY")
                {
                    totalAmont = 1300;
                    txtTotalAmount.Text = totalAmont.ToString();


                }

                if (!int.TryParse(txtDiscount.Text, out discount))// discount
                {
                    MessageBox.Show("Discount is numeric filed and required.", "Insert Error");
                    return;
                }



                //  discount = Convert.ToInt32(txtDiscount.Text);

                if (txtDiscount.Text != null && discount <= 100 && discount >= 0)
                {



                    //  totalAmont = Convert.ToInt32(txtTotalAmount.Text);
                    discount = Convert.ToInt32(txtDiscount.Text);
                    distotal = (totalAmont * discount) / 100;
                    netTotal = totalAmont - distotal;
                    //netTotal = totalAmont * discount / 100;
                    // netTotal=to


                    txtNetTotal.Text = netTotal.ToString();
                    //txtNetTotal.Text = "sdsd".ToString();



                }

                else
                {

                    MessageBox.Show("Discount Filed is contain wrong value OR empty", "Insert Error");

                }



                //update sql

                string updateP = "BEGIN update_patient( id => "+patientId+", name => '"+PatientName+"',ref => '"+Referenece+"',gender => '"+gender+"',address => '"+addresds+"',age => "+age+",phone =>"+phoneNo+",tst => '"+test+"',tot => "+totalAmont+",dis => "+discount+",nt => "+netTotal+",td => TO_DATE('"+date+"', 'DD-MM-YY'));END;";



                try
                {
                    int affectedRowess = oracleDataAccess.ExecuteNonQuery(updateP);
                    MessageBox.Show("Update successful!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update operation failed. Error: " + ex.Message, "Insert Error");
                }







            }

            catch
            {





            }







        }
    }
}
