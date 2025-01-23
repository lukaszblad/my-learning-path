using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace clonable_interface;

public class Point : ICloneable
{
    private int _X = 0;
    private int _Y = 0;
    public int X {get; set;}
    public int Y {get; set;}

    public Point(int providedX, int providedY)
    {
        X = providedX;
        Y = providedY;
    }

    public object Clone() => new Point(this.X, this.Y);
}
