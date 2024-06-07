using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adbms
{
    public partial class AdminInterFace : Form
    {
        public AdminInterFace()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();  
            loginPage.Visible = true;

     
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.Visible = true;
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
           PatientsRecord record = new PatientsRecord();    
            record.Visible = true;
        }
    }
}
