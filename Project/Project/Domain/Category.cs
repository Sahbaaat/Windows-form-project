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
    public class Category:Subject
    {
        public string name;
        public List<Activity> activities = new List<Activity>();
        public List<SuggestedActivity> suggestedactivities = new List<SuggestedActivity>();
        public Category (string n)
        {
            name = n;
        }
        public void AddActivity(Activity a)
        {
            notifyobservers();
            activities.Add(a);
        }
        public void AddSuggestedActivity(SuggestedActivity a)
        {
            suggestedactivities.Add(a);
        }
    }
}
