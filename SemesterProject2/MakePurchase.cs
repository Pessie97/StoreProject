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
    public partial class MakePurchase : Form
    {

        
        public MakePurchase()
        {
            InitializeComponent();
            
            
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                AccountPurchase1 accnt = new AccountPurchase1();
                
                string items = Convert.ToString(comb_items.SelectedItem);
                DateTime date = date_picker.Value;
                int quant = Convert.ToInt16(num_txt.Text);
                int custid = Convert.ToInt16(txt_cust.ToString());
                Customer1 customer = db.Customer1s.Single(u => u.customerID == custid);
                
                accnt.customerID = custid;
                accnt.purchaseDate = date;
                accnt.quantity = quant;
                accnt.prodDescription = items;

                var price = from p in db.Stores
                            where p.prodDescription == items
                            select p.productPrice;
                decimal totalPrice = Convert.ToDecimal(price) * quant;

                customer.customerBalance = customer.customerBalance + totalPrice;

                db.AccountPurchase1s.InsertOnSubmit(accnt);
                db.SubmitChanges();



                MessageBox.Show("Action Completed");
                this.Hide();
                customerPage pg = new customerPage();
                pg.ShowDialog();
            }
           



           
        }
    }
}
