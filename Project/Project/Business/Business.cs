using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Business;
using Project.DataAccess;
using Project.Domain;
using Project.UI;

namespace Project.Business
{
    class Business
    {
        public void SignUp(string username,string email,string password)
        {
            User u = new User(username, email, password);
            UserDA.AddUser(u);
        }
        public bool LogIn(string u,string p)
        {
            User temp=new User(null,null,null);
            foreach (User us in UserDA.users)
            {
                if (u == us.username && p== us.password)
                    temp = us;
            }
            if (temp == null)
                return false;
            else
                return true;
        }
        public void AddCategory(string name)
        {
            Category c = new Category(name);
            CategoryDA.AddCategory(c);
        }
        public Activity SearchActivity(string t)
        {
            Activity act=new Activity(null,null,0,0,0,0);
            foreach (Category c in CategoryDA.categories)
                foreach (Activity a in c.activities)
                    if (a.title == t)
                         act=a;
            if (act.title == null)
                return null;
            else
                return act;

        }
    }
}
