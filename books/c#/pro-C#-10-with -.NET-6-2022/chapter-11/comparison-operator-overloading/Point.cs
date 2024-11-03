namespace comparison_operator_overloading;

public class Point : IComparable<Point>
{
    public required int X {get; set;}
    public required int Y {get; set;}

    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }

    public int CompareTo(Point other)
    {
        if (this.X > other.X && this.Y > other.Y)
        {
            return 1;
        }
        if (this.X < other.X && this.Y < other.Y)
        {
            return -1;
        }
        return 0;
    }

    public static bool operator < (Point p1, Point p2)
    {
        return p1.CompareTo(p2) < 0;
    }
    public static bool operator > (Point p1, Point p2)
    {
        return p1.CompareTo(p2) > 0;
    }
}
