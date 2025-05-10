namespace SmartHomeController.Classes
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
            var speaker = new SpeakerAdapter("Living Room Speaker");

            Sensor motionSensor = new Sensor();
            Sensor nightModeSensor = new Sensor();
            Sensor pinCodeSensor = new Sensor();
            Sensor timeSensor = new Sensor();
            Sensor temperatureSensor = new Sensor();
            Sensor musicSensor = new Sensor();

            motionSensor.Attach(light);
            nightModeSensor.Attach(tv);
            pinCodeSensor.Attach(door);
            timeSensor.Attach(curtain);
            temperatureSensor.Attach(thermostat);
            musicSensor.Attach(speaker);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Smart Home Control Menu ===");
                Console.WriteLine("1. Try Motion Sensor");
                Console.WriteLine("2. Try Night Mode Sensor");
                Console.WriteLine("3. Try Open Door");
                Console.WriteLine("4. Enter Time");
                Console.WriteLine("5. Enter Temperature in Home");
                Console.WriteLine("6. Control Speaker");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Write your action: 'movement' or 'stop'");
                        string move = Console.ReadLine();
                        motionSensor.TriggerEvent(move);
                        break;
                    case "2":
                        Console.WriteLine("Choose TV mode: 'night mode' or 'sleep mode'");
                        string mode = Console.ReadLine();
                        nightModeSensor.TriggerEvent(mode);
                        break;
                    case "3":
                        Console.WriteLine("Write pin code to open the door:");
                        string code = Console.ReadLine();
                        pinCodeSensor.TriggerEvent(code);
                        break;
                    case "4":
                        Console.Write("Enter time (hour in 24h format): ");
                        string time = Console.ReadLine();
                        timeSensor.TriggerEvent(time);
                        break;
                    case "5":
                        Console.WriteLine("Enter temperature: 'hot', 'cold', or 'normal'");
                        string temp = Console.ReadLine();
                        temperatureSensor.TriggerEvent(temp);
                        break;
                    case "6":
                        Console.WriteLine("Enter speaker command: 'play', or 'stop'");
                        string command = Console.ReadLine();
                        musicSensor.TriggerEvent(command);
                        break;
                    case "7":
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong choice :(");
                        break;
                }

                Console.WriteLine("Press 'Enter' to continue...");
                Console.ReadKey();
            }
        }
    }
}
