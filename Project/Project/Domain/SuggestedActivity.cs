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
    public class SuggestedActivity : Activity
    {
        public SuggestedActivity(string ti,string dis,int c,int t,int d,int ad)
            : base(ti, dis,  c, t, d, ad)
            {
            }

        
    }
}
