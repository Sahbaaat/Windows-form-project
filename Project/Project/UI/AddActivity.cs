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
    public partial class AddActivity : Form
    {
        public AddActivity()
        {
            InitializeComponent();
        }

        private void acceptB_Click(object sender, EventArgs e)
        {
            Activity newsuggestedactivity = new Activity(titleT.Text, discriptionT.Text, Convert.ToInt32(costT.Text), Convert.ToInt32(timeT.Text), Convert.ToInt32(distanceT.Text), Convert.ToInt32(advantageT.Text));
            AdminLogin.choosedcategorysuggested.AddActivity(newsuggestedactivity);
            //AdminLogin.choosedcategorysuggested.notifyobservers();
            AdminLogin.choosedcategorysuggested.suggestedactivities.Remove(SuggestedActivityList.choosedsuggestedactivity);
            MessageBox.Show("فعالیت اضافه شد");
            SuggestedActivityList s = new SuggestedActivityList();
            this.Dispose();
            s.ShowDialog();

        }

        private void declineB_Click(object sender, EventArgs e)
        {
            AdminLogin.choosedcategorysuggested.suggestedactivities.Remove(SuggestedActivityList.choosedsuggestedactivity);
            MessageBox.Show("فعالیت بیشنهاد شده حذف شد");
            SuggestedActivityList s = new SuggestedActivityList();
            this.Dispose();
            s.ShowDialog();
        }

        private void AddActivity_Load(object sender, EventArgs e)
        {
            titleT.Text = SuggestedActivityList.choosedsuggestedactivity.title;
            discriptionT.Text = SuggestedActivityList.choosedsuggestedactivity.discription;
            costT.Text = SuggestedActivityList.choosedsuggestedactivity.cost.ToString();
            timeT.Text = SuggestedActivityList.choosedsuggestedactivity.time.ToString();
            advantageT.Text = SuggestedActivityList.choosedsuggestedactivity.advantage.ToString();
            distanceT.Text = SuggestedActivityList.choosedsuggestedactivity.distance.ToString();
        }
    }
}
