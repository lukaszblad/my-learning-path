namespace custom_interfaces;

public struct Triangle : IPointy
{
    private int _points = 3;
    public Triangle() {}

    // interface implementation
    public int Points
    {
        get {return _points;}
    }
}
