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
    public partial class RecordPage : Form
    {
        public RecordPage()
        {
            InitializeComponent();
        }


        private void RecordPage_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Activity a in Login.loggeduser.record.formeractivities)
            {
                DataGridViewRow next = new DataGridViewRow();
                recordlistDG.Rows.Add(next);
                recordlistDG[0, i].Value = i;
                recordlistDG[1, i].Value = a.title;
                recordlistDG[2, i].Value = a.discription;
                recordlistDG[3, i].Value = a.cost;
                recordlistDG[4, i].Value = a.time;
                recordlistDG[5, i].Value = a.distance;
                recordlistDG[6, i].Value = a.advantage;
                i++;
            }
        }

        private void backB_Click(object sender, EventArgs e)
        {
            HomePage h = new HomePage();
            this.Dispose();
            h.ShowDialog();
        }
    }
}
