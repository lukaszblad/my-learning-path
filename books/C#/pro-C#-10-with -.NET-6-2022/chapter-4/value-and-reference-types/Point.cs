namespace value_and_reference_types;

public struct Point
{
    public int X {get; set;}
    public int Y {get; set;}
    public Point()
    {
        X = 0;
        Y = 0;
    }

    public void Display()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
}
