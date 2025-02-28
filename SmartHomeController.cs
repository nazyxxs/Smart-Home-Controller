using HomeController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeController
{
    public class SmartHomeController // Singleton
    {
        private static SmartHomeController instance;
        private static readonly object lockObj = new object();

        private List<Device> devices = new List<Device>();

        private SmartHomeController() { }

        public static SmartHomeController Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new SmartHomeController();
                        }
                    }
                }
                return instance;
            }
        }

        public void AddDevice(Device device)
        {
            devices.Add(device);
            Console.WriteLine($"Device {device.Name} added.");
        }

        public void TurnOnAllDevices()
        {
            foreach (var device in devices)
            {
                device.TurnOn();
            }
        }
    }
}
