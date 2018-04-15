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
    public partial class SuggestedActivityList : Form
    {
        public static SuggestedActivity choosedsuggestedactivity;
        public SuggestedActivityList()
        {
            InitializeComponent();
        }

        private void SuggestedActivityList_Load(object sender, EventArgs e)
        {
            int i = 0;


                foreach (SuggestedActivity s in AdminLogin.choosedcategorysuggested.suggestedactivities)
                {
                    DataGridViewRow next = new DataGridViewRow();
                    suggestedDG.Rows.Add(next);
                    suggestedDG[0, i].Value = i;
                    suggestedDG[1, i].Value = s.title;
                    suggestedDG[2, i].Value = s.discription;
                    i++;
                }
            }

        private void chooseB_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(suggestedDG.SelectedRows[0].Cells[0].Value);
            choosedsuggestedactivity = AdminLogin.choosedcategorysuggested.suggestedactivities[id];
            AddActivity a = new AddActivity();
            this.Dispose();
            a.ShowDialog();
        }

        private void backB_Click(object sender, EventArgs e)
        {
            AdminLogin a = new AdminLogin();
            this.Dispose();
            a.ShowDialog();
        }
    }
}
