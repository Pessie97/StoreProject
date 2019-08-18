using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProject2
{
    public partial class AccountDetail : Form
    {
        public AccountDetail()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                int custID = Convert.ToInt16(txt_custID.Text);

                var accnt = db.Customer1s.Where(ei => ei.customerID == custID);
                lbl_result.Text = accnt.ToString();
            }
          

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerPage page = new customerPage();
            page.ShowDialog();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakePayment pg = new MakePayment(txt_custID.Text.ToString());
            pg.ShowDialog();
        }
    }
}
