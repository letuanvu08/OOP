using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public void NotifyObserver();

    }
    interface IObserver
    {
        public void Update(ISubject subject);
    }
    interface IDisplayElement
    {
        public void Display();
    }

}
