using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeController
{
    public class Curtain : Device
    {
        public Curtain(string name) : base(name) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} is opened.");
        }
    }
}
