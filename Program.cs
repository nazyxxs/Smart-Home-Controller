using System.Xml.Linq;

namespace HomeController
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHomeController home = SmartHomeController.Instance;

            var light = new Light("Living Room Light");
            var tv = new TV("Smart TV");

            Sensor motionSensor = new Sensor();
            Sensor nightModeSensor = new Sensor();

            motionSensor.Attach(light);
            nightModeSensor.Attach(tv);

            // Збереження стану
            var savedLightState = light.SaveState();
            var savedTvState = tv.SaveState();

            Console.WriteLine("\n--- Movement detected ---");
            motionSensor.TriggerEvent("Movement detected!");

            Console.WriteLine("\n--- Activating night mode ---");
            nightModeSensor.TriggerEvent("Activating night mode!");

            // Відновлення стану
            Console.WriteLine("\n--- Restoring previous state ---");
            light.RestoreState(savedLightState);
            tv.RestoreState(savedTvState);
        }
    }
}

