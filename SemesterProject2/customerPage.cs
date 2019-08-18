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
    public partial class customerPage : Form
    {
        public customerPage()
        {
            InitializeComponent();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            //DataClasses1DataContext db1 = new DataClasses1DataContext();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var option = "";
                option = Convert.ToString(options.SelectedItem);

                switch (option)
                {
                    case "Make Purchase":
                        this.Hide();
                        MakePurchase page = new MakePurchase();
                        page.ShowDialog();
                        break;
                    case "View Store Items":
                        this.Hide();
                        ViewStoreItems page2 = new ViewStoreItems();
                        page2.ShowDialog();
                        break;
                    case "View Account Detail":
                        this.Hide();
                        AccountDetail page1 = new AccountDetail();
                        page1.ShowDialog();
                        break;
                    case "View Past Purchases":
                        this.Hide();
                        PastPurchases page3 = new PastPurchases();
                        page3.ShowDialog();
                       
                        break;
                    default: MessageBox.Show("Invalid Option");
                        break;
                }




                db.Dispose();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
    }
}
