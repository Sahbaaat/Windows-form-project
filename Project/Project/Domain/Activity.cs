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
    public class Activity
    {
         public string title;
         public string discription;
         
        public int cost;
        public int time;
        public int distance;
        public int advantage;
        public int takeninweek;
       public Activity(string ti,string dis,int c, int t, int d,int ad)
        {
            takeninweek=0;
            title = ti;
            discription = dis;
            cost = c;
            time = t;
            distance = d;
            advantage = ad;
        }         
    }
}
