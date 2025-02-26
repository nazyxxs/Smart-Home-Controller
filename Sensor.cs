using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeController
{
    public class Sensor // Observer
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer) => observers.Add(observer);
        public void Detach(IObserver observer) => observers.Remove(observer);

        public void TriggerEvent(string message)
        {
            Console.WriteLine($"[Sensor]: {message}");
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}
