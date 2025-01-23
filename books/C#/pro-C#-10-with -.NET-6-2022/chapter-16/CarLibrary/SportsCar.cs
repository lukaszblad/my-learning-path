namespace CarLibrary;

public class SportsCar : Car
{
    public SportsCar(string name, int maxSpeed, int currentSpeed)
        : base (name, maxSpeed, currentSpeed) {}
    public override void TurboBoost()
    {
        Console.WriteLine("Very fast!");
    }
}
