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
    public partial class ActivityPage : Form
    {
        public ActivityPage()
        {
            InitializeComponent();
        }

        private void ActivityPage_Load(object sender, EventArgs e)
        {
            titleT.Text = CategoryPage.choosedactivity.title;
            discriptionT.Text = CategoryPage.choosedactivity.discription;
            costT.Text = CategoryPage.choosedactivity.cost.ToString();
            timeT.Text = CategoryPage.choosedactivity.time.ToString();
            distanceT.Text = CategoryPage.choosedactivity.distance.ToString();
            advantageT.Text = CategoryPage.choosedactivity.advantage.ToString();
            choosedtimeT.Text = CategoryPage.choosedactivity.takeninweek.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryPage.choosedactivity.takeninweek++;
            Login.loggeduser.record.AddActivity(CategoryPage.choosedactivity);
            MessageBox.Show("فعالیت انتخاب شد");
        }

        private void backB_Click(object sender, EventArgs e)
        {
            CategoryPage c = new CategoryPage();
            c.ShowDialog();
            this.Dispose();

        }
    }
}
