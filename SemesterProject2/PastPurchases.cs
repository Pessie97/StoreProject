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
    public partial class PastPurchases : Form
    {
        public PastPurchases()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                int custid = Convert.ToInt16(txt_custId.Text);
                var prev = db.AccountPurchase1s.Where(el => el.customerID == custid)
                    .Select(el => new {ProductID = el.productID,
                                        Quantity = el.quantity,
                                        TotalPrice = el.totalCost,
                                            PurchaseDate = el.purchaseDate});
                //gives the sql code instead of the results
                
                lbl_result.Text = prev.ToString();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerPage page = new customerPage();
            page.ShowDialog();
        }
    }
}
