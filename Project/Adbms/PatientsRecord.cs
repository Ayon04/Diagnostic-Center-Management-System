using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adbms
{
    public partial class PatientsRecord : Form
    {
        private OracleDataAccess oracleDataAccess;
        public PatientsRecord()
        {
            InitializeComponent();
            oracleDataAccess = new OracleDataAccess();

        }

        private void btnRecordsPatients_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable empdt = oracleDataAccess.ExecuteQuery("SELECT * FROM patient order by PATIENTID asc");

                dgvRecords.DataSource = empdt;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PatientsRecord_Load(object sender, EventArgs e)
        {

        }

        private void btnTotalInc_Click(object sender, EventArgs e)//total income
        {

            string total_income = " SELECT calculate_total_income() as Total_income  FROM DUAL";

            try
            {
                DataTable inc = oracleDataAccess.ExecuteQuery(total_income);

                dgvRecords.DataSource = inc;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void totalPatient_Click(object sender, EventArgs e)
        {

            string total_patient = " SELECT calculate_total_patientNo() as Total_Patient_No  FROM DUAL";

            try
            {
                DataTable pno = oracleDataAccess.ExecuteQuery(total_patient);

                dgvRecords.DataSource = pno;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void disTotal_Click(object sender, EventArgs e)//discount total calculation 
        {
            string total_dis = "  SELECT calculate_total_discount() as Total_Discount FROM DUAL";

            try
            {
                DataTable dist = oracleDataAccess.ExecuteQuery(total_dis);

                dgvRecords.DataSource = dist;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)//initial total
        {
            string in_total = " SELECT calculate_initial_total() as initial_total FROM DUAL";

            try
            {
                DataTable itp = oracleDataAccess.ExecuteQuery(in_total);

                dgvRecords.DataSource =itp;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void avgIntialTotal_Click(object sender, EventArgs e)
        {

            string in_total_avg = " SELECT avg_initial_total() as Avarage_initial_total FROM DUAL";

            try
            {
                DataTable ait = oracleDataAccess.ExecuteQuery(in_total_avg);

                dgvRecords.DataSource = ait;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnavgNetTotal_Click(object sender, EventArgs e)
        {
            string net_total_avg = " SELECT avg_net_total() as avg_net_total FROM DUAL";

            try
            {
                DataTable nta = oracleDataAccess.ExecuteQuery(net_total_avg);

                dgvRecords.DataSource = nta;

                oracleDataAccess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
