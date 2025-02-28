using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeController
{
    public class TV : Device
    {
        public TV(string name) : base(name) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{name} is turning on...");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"{name} is turning off...");
        }

        public override void Update(string message)
        {
            if (message.Contains("night mode"))
            {
                TurnOn();
            }
            else if (message.Contains("sleep mode"))
            {
                TurnOff();
            }
        }
    }
}
