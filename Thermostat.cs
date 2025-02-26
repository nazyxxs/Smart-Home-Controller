using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeController
{
    public class Thermostat : Device
    {
        public Thermostat(string name) : base(name) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }
}
