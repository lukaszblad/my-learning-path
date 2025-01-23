namespace custom_interfaces;

public class Square  : IPointy
{
    private int _points = 4;
    public Square() {}

    // interface implementation
    public int Points
    {
        get {return _points;}
    }
}
