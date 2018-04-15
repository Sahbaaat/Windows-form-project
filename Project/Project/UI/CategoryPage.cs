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
    public partial class CategoryPage : Form
    {
        public static Activity choosedactivity;
        public CategoryPage()
        {
            InitializeComponent();
        }

        private void CategoryPage_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Activity a in HomePage.choosedcategory.activities)
            {
                DataGridViewRow next = new DataGridViewRow();
                activitylistdg.Rows.Add(next);
                activitylistdg[0, i].Value = i;
                activitylistdg[1, i].Value = a.title;

                i++;
            }

        }

        private void SubscribeB_Click(object sender, EventArgs e)
        {
            HomePage.choosedcategory.subscribeobserver(Login.loggeduser);
            MessageBox.Show("you are Subscribed!");
            SubscribeB.Hide();
        }

        private void unsubscribeB_Click(object sender, EventArgs e)
        {
            try
            {
                HomePage.choosedcategory.unsubscribeobserver(Login.loggeduser);
                unsubscribeB.Hide();
            }
            catch
            {
                MessageBox.Show("You are not Subscribed yet!");
            }
        }

        private void suggestB_Click(object sender, EventArgs e)
        {
            SuggestActivity s = new SuggestActivity();
            s.ShowDialog();
        }

        private void chooseB_Click(object sender, EventArgs e)
        {
            int id  = Convert.ToInt32(activitylistdg.SelectedRows[0].Cells[0].Value);
            choosedactivity = HomePage.choosedcategory.activities[id];
            ActivityPage a = new ActivityPage();
            this.Dispose();
            a.ShowDialog();

            
        }

        private void backB_Click(object sender, EventArgs e)
        {
            HomePage h = new HomePage();
            this.Dispose();
            h.ShowDialog();
            
        }
    }
}
