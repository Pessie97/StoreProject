using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProject2
{
    public partial class MakePayment : Form
    {
        int custID;
        public MakePayment(string custID)
        {
            InitializeComponent();
            this.custID = Convert.ToInt16(custID);
        }

        private void MakePayment_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var name = from n in db.Customer1s
                           where n.customerID == custID
                           select n.customerName;
                lbl_name.Text = name.ToString();
            }
            
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var totalBal = from b in db.Customer1s
                               where b.customerID == custID
                               select b.customerBalance;
                var credit = from c in db.Customer1s
                             where c.customerID == custID
                             select c.credit;
                Customer1 uCust = db.Customer1s.Single(u => u.customerID == custID);
                if (chk_total.Checked)
                {
                  uCust.customerBalance = 0.0M;
                }
                else if (chk_custom.Checked)
                {
                    decimal bal = Convert.ToDecimal(txt_custom.Text.ToString());
                    decimal leftOver = Convert.ToDecimal(totalBal) - bal;
                    if (leftOver ==0)
                        uCust.customerBalance = 0.0M;
                    else if (leftOver > 0)
                    {
                        decimal cred = Convert.ToDecimal(totalBal) - leftOver;
                        uCust.customerBalance = uCust.customerBalance - cred;
                        uCust.credit = cred;
                    }
                    else
                    {
                        decimal left = Math.Abs(Convert.ToDecimal(totalBal) - leftOver);
                        uCust.customerBalance = 0.0M;
                        uCust.credit = Convert.ToDecimal(credit) + left;
                    }
                }
                    
                    

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountDetail pg = new AccountDetail();
            pg.ShowDialog();
        }
    }
}
