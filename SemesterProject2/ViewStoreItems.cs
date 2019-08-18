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
    public partial class ViewStoreItems : Form
    {
        public ViewStoreItems()
        {
            InitializeComponent();
        }

        private void ViewStoreItems_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var items = db.Stores.SelectMany(p => p.prodDescription + ' ' + p.productPrice).ToString();
                txt_items.Text = items;
            }
            
        }
    }
}
