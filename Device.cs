using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeController
{
    public abstract class Device : IObserver, IStatefulDevice
    {
        protected string name;
        protected bool isOn;

        public string Name => name;

        protected Device(string name)
        {
            this.name = name;
        }

        public virtual void TurnOn()
        {
            isOn = true;
            Console.WriteLine($"{name} is turned on.");
        }

        public virtual void TurnOff()
        {
            isOn = false;
            Console.WriteLine($"{name} is turned off.");
        }

        public virtual void Update(string message)
        {
            Console.WriteLine($"{name} received update: {message}");
        }

        public DeviceState SaveState()
        {
            Console.WriteLine($"{name} state saved.");
            return new DeviceState(name, isOn);
        }

        public void RestoreState(DeviceState state)
        {
            isOn = state.IsOn;
            Console.WriteLine($"{name} restored to state: {(isOn ? "On" : "Off")}");
        }
    }
}
