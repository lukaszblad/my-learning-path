namespace operator_overloading;

public class Point
{
    public int X {get; set;}
    public int Y {get; set;}

    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }

    // operator overloading
    public static Point operator + (Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    public static Point operator - (Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }

    // binary operator do not require arguments of the same type
    public static Point operator + (Point p1, int change)
    {
        return new Point(p1.X + change, p1.Y + change);
    }

    // for arguments to be passed in either order, also this
    // definition is needed
    public static Point operator - (int change, Point p1)
    {
        return new Point(p1.X - change, p1.Y - change);
    }

    // overloading binary operators give access to += and -= as well
}
