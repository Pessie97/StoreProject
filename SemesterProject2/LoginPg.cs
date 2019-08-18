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
    public partial class LoginPg : Form
    {
       

        public LoginPg()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var uname = txt_uname.Text;
            var pword = txt_pass.Text;
            var customers = db.Customer1s;
            foreach(var val in customers)
            {
                var password = val.password;
                var username = val.username;

                if (uname==username)
                    if (pword==password)
                    {
                        this.Hide();
                        customerPage page = new customerPage();
                        page.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }

            


            db.Dispose();
        }

        
    }
}
