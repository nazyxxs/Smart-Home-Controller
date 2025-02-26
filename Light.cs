using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeController
{
    public class Light : Device
    {
        public Light(string name) : base(name) { }

        public override void TurnOn()
        {
            isOn = true;
            Console.WriteLine($"{name} is shining.");
        }

        public override void Update(string message)
        {
            if (message.Contains("movement"))
            {
                TurnOn();
            }
        }
    }


}
