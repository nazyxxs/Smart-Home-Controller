using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace HomeController
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHomeController home = SmartHomeController.Instance;

            var light = new Light("Living Room Light");
            var tv = new TV("Smart TV");
            var door = new Door("Main door");
            var curtain = new Curtain("Curtain in bedroom");
            var thermostat = new Thermostat("Thermostat bedroom");

            Sensor motionSensor = new Sensor();
            Sensor nightModeSensor = new Sensor();
            Sensor pinCodeSensor = new Sensor();
            Sensor timeSensor = new Sensor();
            Sensor temperatureSepsor = new Sensor();

            motionSensor.Attach(light);
            nightModeSensor.Attach(tv);
            pinCodeSensor.Attach(door);
            timeSensor.Attach(curtain);
            temperatureSepsor.Attach(thermostat);


            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Smart Home Control Menu ===");
                Console.WriteLine("1. Try Motion Sensor");
                Console.WriteLine("2. Try night mode Sensor");
                Console.WriteLine("3. Try open door");
                Console.WriteLine("4. Enter time");
                Console.WriteLine("5. Enter temperature in home");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Write your action: \'movement / stop\'");
                        string move = Console.ReadLine();
                        motionSensor.TriggerEvent(move);
                        break;
                    case "2":
                        Console.WriteLine("Choose TV mode: \'night mode / sleep mode\'");
                        string mode = Console.ReadLine();
                        nightModeSensor.TriggerEvent(mode);
                        break;
                    case "3":
                        Console.WriteLine("Write pin code to the door");
                        string code = Console.ReadLine();
                        pinCodeSensor.TriggerEvent(code);
                        break;
                    case "4":
                        Console.Write("Enter time:");
                        string time = Console.ReadLine();
                        timeSensor.TriggerEvent(time);
                        break;
                    case "5":
                        Console.WriteLine("Enter temperature: hot / cold / normal");
                        string temperattt = Console.ReadLine();
                        temperatureSepsor.TriggerEvent(temperattt);
                        break;
                    case "6":
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong choice :(");
                        break;
                }

                Console.WriteLine("Press \'Enter\' to continue...");
                Console.ReadKey();

            }

        }
    }
}

