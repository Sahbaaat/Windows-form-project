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
    public  class User :Person,Observer
    {
        public Record record;
        private int location;

        public User (string u, string e,string p )
        {
            username = u;
            email = e;
            password = p;
            string locaton;
            record = new Record();
        }

        public Notificaton update()
        {
            Notificaton n = new Notificaton("blah blah!");
            return n;

        }
    }
}
