class MyMathClass
{
    // Read-only fields can be assigned in constructors, 
    // but nowhere else.
    public readonly double PI;
    public MyMathClass()
    {
        PI = 3.14;
    }
}

class MyMathClass1
{
    // not implicitly static
    public static readonly double PI;
    static MyMathClass1()
    { PI = 3.14; }
}
