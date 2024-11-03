namespace custom_conversion_routines;

public struct Square
{
    public int Length {get; set;}

    public Square(int l)
    {
        Length = l;
    }

    // explicit conversion of Rectangles to Squares
    public static explicit operator Square(Rectangle r)
    {
        Square s = new Square {Length = r.Height};
        return s;
    }
}
