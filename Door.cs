using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeController
{
    public class Door : Device
    {
        public Door(string name) : base(name) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} is opened.");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"{name} is closed.");
        }
        public override void Update(string pinCode)
        {
            if (pinCode.Contains("1234"))
            {
                TurnOn();
                var light = new Light("Living Room Light");
                Sensor motionSensor = new Sensor();
                motionSensor.Attach(light);
                motionSensor.TriggerEvent("movement");
            }
            else
            {
                Console.WriteLine("Wrong pin code!");
                TurnOff();
            }
        }
    }
}
