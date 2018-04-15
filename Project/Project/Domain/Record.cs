using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Business;
using Project.DataAccess;
using Project.Domain;
using Project.UI;

namespace Project.Domain
{
    public class Record
    {
        public List<Activity> formeractivities = new List<Activity>();
        public void AddActivity(Activity a)
        {
            formeractivities.Add(a);
        }

    }
}
