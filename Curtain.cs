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
        public override void TurnOff()
        {
            Console.WriteLine($"{Name} is clodsed");
        }

        public override void Update(string time)
        {
            int timeInt = int.Parse(time);

            if (timeInt >= 8 && timeInt <= 21)
            {
                TurnOn();
            }
            else
            {
                TurnOff();
            }
        }
    }
}
