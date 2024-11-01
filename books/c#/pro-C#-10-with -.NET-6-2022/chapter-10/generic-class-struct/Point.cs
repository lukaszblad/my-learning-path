using System.Security.Cryptography.X509Certificates;

namespace generic_class_struct;

public struct Point<T>
{
    public T X {get; set;}
    public T Y {get; set;}

    public Point(T xPos, T yPos)
    {
        X = xPos;
        Y = yPos;
    }
}
