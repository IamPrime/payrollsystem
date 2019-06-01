using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSytem.Includes;


namespace PayrollSytem
{
    public partial class LoginMg : Form
    {
        private Master frm;
        public LoginMg(Master frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        SQLConfig config = new SQLConfig();
        string sql;
        private void btn_login_Click(object sender, EventArgs e)
        {
            sql = "SELECT * from user WHERE username = '" + txt_username.Text + "' and Pass = sha('" + txt_password.Text + "')";
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            { 
                frm.enable_menu();
                this.Close();
            }
            else
            {
                MessageBox.Show("Accounts does not exist! please contact administrator","login failed",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
