using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeController
{
    public class DeviceState // Memento
    {
        public bool IsOn { get; }
        public string Name { get; }

        public DeviceState(string name, bool isOn)
        {
            Name = name;
            IsOn = isOn;
        }
    }
}
