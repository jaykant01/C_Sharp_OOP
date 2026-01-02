namespace Inheritance_Practice;

public class Device
{
    public int DeviceId;
    public string Status;

    public Device(int deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device Status:");
        Console.WriteLine($"Device ID : {DeviceId}");
        Console.WriteLine($"Status    : {Status}");
    }
}

class Thermostat : Device
{
    public double TemperatureSetting;

    public Thermostat(int deviceId, string status, double temperatureSetting)
        : base(deviceId, status)
    {
        TemperatureSetting = temperatureSetting;
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Temperature Setting : {TemperatureSetting}°C");
    }
}
