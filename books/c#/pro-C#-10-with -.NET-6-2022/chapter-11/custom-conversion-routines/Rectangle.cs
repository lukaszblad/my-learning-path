namespace custom_conversion_routines;

public struct Rectangle
{
    public int Width {get; set;}
    public int Height {get; set;}

    public Rectangle(int w, int h)
    {
        Width = w;
        Height = h;
    }

    // implicit convertion of a Square into a Rectangle
    public static implicit operator Rectangle(Square s)
    {
        Rectangle r = new Rectangle
        {
            Height = s.Length,
            Width = s.Length,
        };
        return r;
    }
}
