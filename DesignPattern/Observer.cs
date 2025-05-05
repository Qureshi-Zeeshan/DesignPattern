using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    interface ISubject
    {
        void Attach(IObserves IObserver);
        void Detach(IObserves IObserver);
        //void Notify();
    }
    interface IObserves
    {
        void Update(string Message);
    }

    class Observers : IObserves

    {
        private string name;
        public Observers (string name)
        {
            this.name = name;
        }
        public void Update(string message)
        {
            Console.WriteLine($"{name} {message}"); 
        }
    }
    internal class Subject : ISubject
    {
        private List<IObserves> Observers = new List<IObserves>();
        private string Message;

         public void Attach(IObserves IObserver)
         {
            Observers.Add(IObserver);
         }

        public void Detach(IObserves IObserver)
        {
            Observers.Remove(IObserver);
        }

        private void Notify()
        {
            foreach(IObserves Observer in Observers)
            {
                Observer.Update(Message);
            }
        }
        public int ShowObservers () => Observers.Count;
        

        public void NewContent(string ContentName)
        {
            Message =$"The new content is {ContentName}";
            Notify();
        }
    }
}
