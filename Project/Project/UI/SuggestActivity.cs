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
    public partial class SuggestActivity : Form
    {
        public SuggestActivity()
        {
            InitializeComponent();
        }

        private void backB_Click(object sender, EventArgs e)
        {
            HomePage h = new HomePage();
            h.ShowDialog();
        }

        private void suggestB_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(timeT.Text) > 0 && Convert.ToInt32(costT.Text) > 0 && Convert.ToInt32(distanceT.Text) > 0
                    && Convert.ToInt32(advantageT.Text) > 0 && Convert.ToInt32(timeT.Text) < 6 && Convert.ToInt32(costT.Text)
                    < 6 && Convert.ToInt32(distanceT.Text) < 6 && Convert.ToInt32(advantageT.Text) < 6)
                {
                    SuggestedActivity newsuggestedactivity = new SuggestedActivity(titleT.Text, discriptionT.Text, Convert.ToInt32(costT.Text), Convert.ToInt32(timeT.Text), Convert.ToInt32(distanceT.Text), Convert.ToInt32(advantageT.Text));
                    HomePage.choosedcategory.AddSuggestedActivity(newsuggestedactivity);
                    MessageBox.Show("بیشنهاد شما ثبت شد");
                    CategoryPage c = new CategoryPage();
                    this.Dispose();
                    c.ShowDialog();

                }

                else
                    MessageBox.Show("اطلاعات وارد شده نا معتبر است");
            }

            catch
            {
                MessageBox.Show("اطلاعات وارد شده نا معتبر است");
            }
        }
    }
}
