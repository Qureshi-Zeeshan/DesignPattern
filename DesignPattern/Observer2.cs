using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    interface ISubject2
    {
        void Attach(IObserver2 Observer);
        void Detach(IObserver2 Observer);
        void Notify();
    }
    interface IObserver2
    {
        void Update(string Message);
    }
    class Subject2 : ISubject2
    {
        List<IObserver2> list =new List<IObserver2>();
        private string Message;

        public void Attach(IObserver2 Observer)
        {
           list.Add(Observer);
        }

        public void Detach(IObserver2 Observer)
        {
            list.Remove(Observer);
        }

        public void Notify()
        {
            foreach (var item in list)
            {
                item.Update(Message);
            }
        }

        public void SetTemperature(string Message)
        {
           this.Message= Message;
            Notify();
        }

    }


    internal class Observer2 : IObserver2 
    {
        private string Name;
        public Observer2(string Name)
        {
            this.Name = Name;
        }
        public void Update(string Message)
        {
            Console.WriteLine($"{Name} New Temperature is {Message}");
        }
    }
}
