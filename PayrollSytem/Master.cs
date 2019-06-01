using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PayrollSytem
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }
        
        public void enable_menu()
        {
            tsLogin.Text = "Logout";
            tsLogin.Image = PayrollSytem.Properties.Resources.iconfinder_logout_63128;
            tsEmployee.Enabled = true;
            tsPayroll.Enabled = true;
            tsUser.Enabled = true;
            tsReport.Enabled = true;

        }
         
        private void Form1_Load(object sender, EventArgs e)
        {

        }

         

        private void closeChildForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsEmployee_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new EmployeesMg());
        }

        private void tsPayroll_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new PayrollMg());
        }

        private void tsUser_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new UserMg());
        }

        private void tsReport_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new ReportsMg());
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            if (tsLogin.Text == "Login")
            {
                closeChildForm();
                showFrm(new LoginMg(this));
            }
            else
            {
                tsLogin.Text = "Login";
                tsLogin.Image = PayrollSytem.Properties.Resources.iconfinder_lock_safe_password_2992204;
                tsEmployee.Enabled = false;
                tsPayroll.Enabled = false;
                tsUser.Enabled = false;
                tsReport.Enabled = false;
            }
        }
    }
}
