namespace SmartHomeController
{

    public class SmartHomeController // Singleton
    {
        private static SmartHomeController instance;
        private static readonly object lockObj = new object();

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
    }

    public abstract class Device
    {
        private string name;

        void TurnOn() => Console.WriteLine("Turning on the device...");
        void TurnOff() => Console.WriteLine("Turning off the device...");
    }

    public class Light : Device
    {
        // ToDo
    }
    public class Thermostat : Device
    {
        // ToDo
    }
    public class Door : Device
    {
        // ToDo
    }
    public class Curtain : Device
    {
        // ToDo
    }
    public class TV : Device
    {
        // ToDo
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

