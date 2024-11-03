using System.Drawing;

unsafe
{
    // can work with pointers
}
// cannot work with pointers

static unsafe void SquareIntPointer(int* myIntPointer)
{
    *myIntPointer *= *myIntPointer;
}

unsafe
{
    int myInt = 10;

    SquareIntPointer(&myInt);
    Console.WriteLine($"my int: {myInt}");

    Point point;
    Point* p = &point;
    // to access the parameters of Point from a pointer, needs to use the
    // field-access operator ->
    p -> X = 100;
    p -> Y = 200;
    Console.WriteLine(p -> ToString());
}

// Stack allocation
static unsafe string StackAllocation()
{
    char* p = stackalloc char[52];
    for (int k = 0; k < 52; k++)
    {
        p[k] = (char)(k + 65);
    }
    return new string(p);
}

Console.WriteLine(StackAllocation());
