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
    public partial class AdminLogin : Form
    {
        public static Category choosedcategorysuggested;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Category c in CategoryDA.categories)
            {
                DataGridViewRow next = new DataGridViewRow();
                categorysuggestedlistdg.Rows.Add(next);
                categorysuggestedlistdg[0, i].Value = i;
                categorysuggestedlistdg[1, i].Value = c.name;
                i++;
            }
        }

        private void chooseB_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(categorysuggestedlistdg.SelectedRows[0].Cells[0].Value);
            choosedcategorysuggested = CategoryDA.categories[id];
            SuggestedActivityList s = new SuggestedActivityList();
            this.Dispose();
            s.ShowDialog();
        }

        private void backB_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Dispose();
            l.ShowDialog();
        }
    }
}
