using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain;

namespace Project.DataAccess
{

    class UserDA
    {
        static public List<User> users;
        private static UserDA instance;
        public static UserDA Instance             ///singleton
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDA();
                }
                return instance;
            }
        }
        public UserDA()
        {
            users = new List<User>();
            UserDA.AddUser(new User("test", " test", "test"));
            UserDA.AddUser(new User("sahba", " sahba", "123"));
        }
        static public List<User> UsersList()
        {
            return users;
        }

        static public void AddUser(User u)
        {
            users.Add(u);
        }
    }
}
