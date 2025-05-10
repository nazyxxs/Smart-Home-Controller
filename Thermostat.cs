namespace SmartHomeController.Classes;

public class Thermostat : Device
{
    public Thermostat(string name) : base(name) { }
    public override void TurnOn()
    {
        Console.WriteLine($"{Name} is working.");
    }
    public override void TurnOff()
    {
        Console.WriteLine($"{Name} is off");
    }

    public override void Update(string message)
    {

        if (message.Contains("hot"))
        {
            TurnOn();
            Console.WriteLine("Enjoy cold wind!");
        }
        else if (message.Contains("cold"))
        {
            TurnOn();
            Console.WriteLine("Enoy warm wind!");
        }
        else
        {
            TurnOff();
        }

    }
}