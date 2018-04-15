using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Business;
using Project.DataAccess;
using Project.Domain;
using Project.UI;

namespace Project.UI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signupB_Click(object sender, EventArgs e)
        {
            try
            {
                User newuser = new User(usernameT.Text, emailT.Text, passwordT.Text);
                Login l = new Login();
                this.Dispose();
                l.ShowDialog();
            }
            catch
            {
                MessageBox.Show("اطلاعات وارد شده نامعتبر است");
                usernameT.Clear();
                emailT.Clear();
                passwordT.Clear();
            }
            

        }
    }
}
