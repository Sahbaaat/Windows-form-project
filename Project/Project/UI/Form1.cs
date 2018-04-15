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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             CategoryDA cda =CategoryDA.Instance;
            UserDA uda = UserDA.Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            
            l.ShowDialog();
            this.Dispose();


        }
    }
}
