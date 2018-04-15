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
    public partial class HomePage : Form
    {
        public  static Category choosedcategory;
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Category c in CategoryDA.CategoriesList())
            {
                DataGridViewRow next = new DataGridViewRow();
                categorylistdg.Rows.Add(next);
                categorylistdg[0, i].Value = i;
                categorylistdg[1, i].Value = c.name;
                i++;
            }

        }

        private void recordsB_Click(object sender, EventArgs e)
        {
            RecordPage r = new RecordPage();
            this.Dispose();
            r.ShowDialog();

        }

        private void suggestB_Click(object sender, EventArgs e)
        {
            SuggestActivity s = new SuggestActivity();
            this.Dispose();
            s.ShowDialog();
        }



        private void chooseB_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(categorylistdg.SelectedRows[0].Cells[0].Value);
            choosedcategory = CategoryDA.categories[id];
            CategoryPage a = new CategoryPage();
            this.Dispose();
            a.ShowDialog();
        }

        private void backB_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Dispose();
            l.ShowDialog();
        }
    }
}
