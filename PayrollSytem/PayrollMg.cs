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
    public partial class PayrollMg : Form
    {
        public PayrollMg()
        {
            InitializeComponent();
        }


        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void calc_on_dedution()
        {
            try
            {
                double ca, phic, pagibig, d1, d2, d3, d4, total_deduction, gross, total_net;

                ca = double.Parse(txtpcadvance.Text);
                phic = double.Parse(txtpphic.Text);
                pagibig = double.Parse(txtppagibig.Text);
                d1 = double.Parse(txtpdeduct1.Text);
                d2 = double.Parse(txtpdeduct2.Text);
                d3 = double.Parse(txtpdeduct3.Text);
                d4 = double.Parse(txtpdeduct4.Text);
                gross = double.Parse(txtpgincome.Text);

                total_deduction = ca + phic + pagibig + d1 + d2 + d3 + d4;
                txtpdeducttot.Text = total_deduction.ToString();

                total_net = gross - total_deduction;
                txtpnetincome.Text = total_net.ToString();
            }
            catch
            {

            }
           
        }

        private void load_data()
        {
            sql = "SELECT DISTINCT (" +
             "p.`trans_id`" +
             "),e.emp_code as 'Assign Code', CONCAT(  `emp_fname` ,  ' ',  `emp_lname` ,  ' ',  `emp_mname` ) AS  'Employee'" +
             ",  `d_rate` AS 'DailyRate' ,  `num_days` AS 'NumberOfDays' ,  `r_wage` AS 'RateWage', "
             + " `gross_sal` AS 'GrossIncome', `total_ded` AS 'TotalDeduction',  `net_income` AS 'NetIncome' ,  " +
             " `position` AS 'Postion',`remarks` AS 'Remarks' ,`dateissued` AS 'DateIssued'    " +
             "FROM  `employee` e,  `payroll` p,  `employee_workinfo` ew,  `other_deduction` od " +
             "WHERE e.`emp_code` = p.`emp_code` " +
             "AND p.`emp_code` = ew.`emp_code` " +
             "AND p.`trans_id` = od.`trans_id` " +
             "AND  (emp_fname  LIKE '%" + txtpsearch.Text + "%'" +
             "OR  emp_lname  LIKE '%" + txtpsearch.Text + "%'" +
             "OR e.emp_code LIKE '%" + txtpsearch.Text + "%')";
            config.Load_DTG(sql, dtgParollList);
            dtgParollList.Columns[0].Visible = false;
            funct.ResponsiveDtg(dtgParollList);


            sql = "SELECT concat(autoname,strnum) as auto FROM autonumber WHERE id = 1";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txttrancode.Text = config.dt.Rows[0].Field<string>("auto");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtPEmployeeName.Text = "";
            txtpremarks.Text = "";
            txtPAssignCode.Text = "";
            funct.clearTxt(GroupBox3);
            funct.clearTxt(GroupBox4);
            funct.clearTxt(GroupBox5);
            funct.clearTxt(GroupBox6);
            txtPrateWage.Text = "0";
            txtPregOt.Text = "0";
            txtPholPay.Text = "0";
            txtpgincome.Text = "0";
            txtpnetincome.Text = "0";
            txtpdeducttot.Text = "0";
            txtpcadvance.Text = "0";
            txtpphic.Text = "0";
            txtppagibig.Text = "0";
            txtpdeduct1.Text = "0";
            txtpdeduct2.Text = "0";
            txtpdeduct3.Text = "0";
            txtpdeduct4.Text = "0";


        }

        private void frm_Payroll_Load(object sender, EventArgs e)
        {
            load_data();

           
        
        }

        private void txtPAssignCode_TextChanged(object sender, EventArgs e)
        { 

            sql = "SELECT * FROM `employee` e, `employee_workinfo` ew " 
                + " WHERE e.`emp_code`=ew.`emp_code` AND e.emp_code ='" + txtPAssignCode.Text + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txtPRateperday.Text = config.dt.Rows[0].Field<int>("d_rate").ToString();
                txtPPayPeriod.Text = config.dt.Rows[0].Field<string>("p_method").ToString();
                txtPEmployeeName.Text = config.dt.Rows[0].Field<string>("emp_fname").ToString()
                + " " + config.dt.Rows[0].Field<string>("emp_lname").ToString() + " " 
                + config.dt.Rows[0].Field<string>("emp_mname").ToString();
            }
            else
            {
                txtPEmployeeName.Text = "";
                txtpremarks.Text = ""; 
                funct.clearTxt(GroupBox3);
                funct.clearTxt(GroupBox4);
                funct.clearTxt(GroupBox5);
                funct.clearTxt(GroupBox6);
                txtPrateWage.Text = "0";
                txtPregOt.Text = "0";
                txtPholPay.Text = "0";
                txtpgincome.Text = "0";
                txtpnetincome.Text = "0";
                txtpdeducttot.Text = "0";
            }
             
        }

        private void txtPNoDays_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                double rateWage, grossincome, neticome,ot,holpay;

                ot = double.Parse(txtPregOt.Text);
                holpay = double.Parse(txtPholPay.Text);

                if (txtPNoDays.Text == "" || txtPNoDays.Text == "0")
                {
                    txtPrateWage.Text = "0";
                    rateWage = double.Parse(txtPrateWage.Text);

                }
                else
                {
                    rateWage = double.Parse(txtPRateperday.Text) * double.Parse(txtPNoDays.Text);
                    txtPrateWage.Text = rateWage.ToString();

                }


                

                grossincome = rateWage + ot + holpay;
                txtpgincome.Text = grossincome.ToString();


                neticome = grossincome - double.Parse(txtpdeducttot.Text);
                txtpnetincome.Text = neticome.ToString();
            }
            catch (Exception ex)
            {

            } 
        }

        private void txtPRegOtHr_TextChanged(object sender, EventArgs e)
        {
            try
            { 

              

                double total, total_OT,grossincome , neticome, ot, holpay, rateWage;
             

                if(txtPRegOtHr.Text=="" || txtPRegOtHr.Text == "0")
                {
                    txtPregOt.Text = "0";
                }
                else
                {
                    total = Double.Parse(txtPRateperday.Text) / 8;
                    total_OT = total * Double.Parse(txtPRegOtHr.Text);
                    txtPregOt.Text = total_OT.ToString();

                }

                ot = double.Parse(txtPregOt.Text);
                holpay = double.Parse(txtPholPay.Text);
                rateWage = double.Parse(txtPrateWage.Text);

                grossincome = rateWage + ot + holpay;
                txtpgincome.Text = grossincome.ToString();

                neticome = grossincome - double.Parse(txtpdeducttot.Text);
                txtpnetincome.Text = neticome.ToString();

            }
            catch
            {

            } 
        }
 
        private void txtPholPayDay_TextChanged(object sender, EventArgs e)
        {
            try
            {



                double total_hol, grossincome, neticome, ot, holpay, rateWage;

                if (txtPholPayDay.Text == "" || txtPholPayDay.Text == "0")
                {
                    txtPholPay.Text = "0";
                }
                else
                {
                    total_hol = double.Parse(txtPRateperday.Text) * double.Parse(txtPholPayDay.Text);

                    txtPholPay.Text = total_hol.ToString();

                }

                ot = double.Parse(txtPregOt.Text);
                holpay = double.Parse(txtPholPay.Text);
                rateWage = double.Parse(txtPrateWage.Text);

                grossincome = rateWage + ot + holpay;
                txtpgincome.Text = grossincome.ToString();

                neticome = grossincome - double.Parse(txtpdeducttot.Text);
                txtpnetincome.Text = neticome.ToString();

            }
            catch
            {

            }

        }

        private void txtpcadvance_TextChanged(object sender, EventArgs e)
        {
          

            if(txtpcadvance.Text == "" || txtpcadvance.Text == "0")
            {
                txtpcadvance.Text = "0";

            }

            calc_on_dedution();


        }

        private void txtpphic_TextChanged(object sender, EventArgs e)
        {
            if (txtpphic.Text == "" || txtpphic.Text == "0")
            {
                txtpphic.Text = "0";

            }
            calc_on_dedution();
        }

        private void txtppagibig_TextChanged(object sender, EventArgs e)

        {
            if (txtppagibig.Text == "" || txtppagibig.Text == "0")
            {
                txtppagibig.Text = "0";

            }
            calc_on_dedution();
        }

        private void txtpdeduct1_TextChanged(object sender, EventArgs e)
        {
            if (txtpdeduct1.Text == "" || txtpdeduct1.Text == "0")
            {
                txtpdeduct1.Text = "0";

            }
            calc_on_dedution();
        }

        private void txtpdeduct2_TextChanged(object sender, EventArgs e)
        {
            if (txtpdeduct2.Text == "" || txtpdeduct2.Text == "0")
            {
                txtpdeduct2.Text = "0";

            }
            calc_on_dedution();
        }

        private void txtpdeduct3_TextChanged(object sender, EventArgs e)
        {
            if (txtpdeduct3.Text == "" || txtpdeduct3.Text == "0")
            {
                txtpdeduct3.Text = "0";

            }
            calc_on_dedution();

        }

        private void txtpdeduct4_TextChanged(object sender, EventArgs e)
        {
            if (txtpdeduct4.Text == "" || txtpdeduct4.Text == "0")
            {
                txtpdeduct4.Text = "0";

            }
            calc_on_dedution();
        }

        private void btnPsave_Click(object sender, EventArgs e)
        {

            if (txtPNoDays.Text == "" || txtPregOt.Text == "" || txtPholPay.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO `other_deduction` " 
                               + "(`emp_code`, `deduct1`, `ded_amount1`, `deduct2`, `ded_amount2`, `deduct3`, "
                               + "`ded_amount3`, `deduct4`, `ded_amount4`, `total_ded`,trans_id)"
                               + " VALUES ('" + txtPAssignCode.Text + "','" + txtpdeductname1.Text + "','"
                               + txtpdeduct1.Text + "','" + txtpdeductname2.Text + "','" + txtpdeduct2.Text
                               + "','" + txtpdeductname3.Text + "','" + txtpdeductname3.Text
                               + "','" + txtpdeductname4.Text + "','" + txtpdeductname4.Text
                               + "','" + txtpdeducttot.Text + "','" + txttrancode.Text + "')";
                config.Execute_Query(sql);

                sql = "INSERT INTO  `payroll` " 
                    + "(`emp_code`, `num_days`, `r_wage`, `overtime`, `hol_pay`, `gross_sal`" 
                    + ", `cash_ad`, `bread_vale`, `philhealth`, `pag-ibig`, `net_income`, `remarks`,`dateissued`,trans_id)" 
                    + " VALUES ('" + txtPAssignCode.Text + "','" + txtPNoDays.Text + "','" 
                    + txtPrateWage.Text + "','" + txtPregOt.Text + "','" + txtPholPay.Text 
                    + "','" + txtpgincome.Text + "','" + txtpcadvance.Text + "','" + txtbvale.Text 
                    + "','" + txtpphic.Text + "','" + txtppagibig.Text + "','" + txtpnetincome.Text 
                    + "','" + txtpremarks.Text + "',Now(),'" + txttrancode.Text + "')";

                config.Execute_Query(sql);

                MessageBox.Show("Data has been saved in the database.");

                config.Execute_Query("UPDATE autonumber SET strnum = strnum + increment WHERE id =1");
                txtPAssignCode.Text = "";

                load_data();


            }
           
        }

        private void txtpsearch_TextChanged(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
