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
    public abstract class Subject
    {
        List<Observer> observers = new List<Observer>();
        public void subscribeobserver(Observer o)
        {
            observers.Add(o);
        }
        public void unsubscribeobserver(Observer o)
        {
            observers.Remove(o);
        }
        public void notifyobservers()
        {
            foreach (Observer o in observers)
                o.update();
        }
    }
}
