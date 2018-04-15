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

    public partial class Login : Form
    {
        public static User loggeduser;
        public Login()
        {
            InitializeComponent();
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            if (usernameT.Text == "admin" && passwordT.Text == "admin")
            {
                AdminLogin l = new AdminLogin();
                this.Dispose();
                l.ShowDialog();
                
            }

            else
            {
                foreach (User u in UserDA.users)
                {
                    if (usernameT.Text == u.username && passwordT.Text == u.password)
                        loggeduser = u;
                    HomePage h = new HomePage();
                    this.Dispose();
                    h.ShowDialog();
                }
                if (loggeduser == null)
                {
                    MessageBox.Show("Wrong Username/Password!");
                    this.Dispose();
                    Login l = new Login();
                    l.ShowDialog();
                }
            }
        }
    }
}
