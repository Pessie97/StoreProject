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
    public partial class MakePurchaseVerification : Form
    {
        public MakePurchaseVerification()
        {
            InitializeComponent();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakePurchase pg = new MakePurchase();
            pg.ShowDialog();
        }
    }
}
