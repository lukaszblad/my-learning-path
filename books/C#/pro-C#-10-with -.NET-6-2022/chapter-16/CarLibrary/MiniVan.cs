namespace CarLibrary;

public class MiniVan : Car
{
    public MiniVan(string name, int maxSpeed, int currentSpeed)
        : base (name, maxSpeed, currentSpeed) {}
    public override void TurboBoost()
    {
        Console.WriteLine("Very Nice");
    }
}
