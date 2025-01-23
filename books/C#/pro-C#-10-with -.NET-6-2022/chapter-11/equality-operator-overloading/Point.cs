namespace equality_operator_overloading;

public class Point
{
    public required int X {get; set;}
    public required int Y {get; set;}

    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }

    public override bool Equals(object? obj)
    {
        return obj.ToString() == this.ToString();
    }

    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }

    // equality operator override
    public static bool operator == (Point p1, Point p2)
    {
        return p1.Equals(p2);
    }

    public static bool operator != (Point p1, Point p2)
    {
        return !p1.Equals(p2);
    } 
}
