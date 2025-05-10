namespace SmartHomeController.Classes;

public class Light : Device
{
    public Light(string name) : base(name) { }

    public override void TurnOn()
    {
        isOn = true;
        Console.WriteLine($"{name} is shining.");
    }
    public override void TurnOff()
    {
        isOn = false;
        Console.WriteLine($"{name} turned off");
    }

    public override void Update(string message)
    {
        if (message.Contains("movement"))
        {
            TurnOn();
        }
        else if (message.Contains("stop"))
        {   
            TurnOff();
        }
    }
}