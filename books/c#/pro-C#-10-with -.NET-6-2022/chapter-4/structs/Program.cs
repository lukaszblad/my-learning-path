Console.WriteLine("***** A First Look at Structures *****\n");
// Create an initial Point. 
Point myPoint;
myPoint.X = 349;
myPoint.Y = 76;
myPoint.Display();
// Adjust the X and Y values. 
myPoint.Increment();
myPoint.Display();

// Set all fields to default values 
// using the default constructor. 
Point p1 = new Point();
// Prints X=0,Y=0. 
p1.Display();

var s = new DisposableRefStruct(50, 60);
s.Display();
s.Dispose();

struct Point
{
    // Fields of the structure. 
    public int X = 0;
    public int Y = 0;

    //Parameterless constructor, used before C#10
    //public Point()
    //{
    //    X = 0;
    //    Y = 0;
    //}

    // A custom constructor. (added with C#10)
    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }

    // Add 1 to the (X, Y) position. 
    public void Increment()
    {
        X++; Y++;
    }
    // Subtract 1 from the (X, Y) position. 
    public void Decrement()
    {
        X--; Y--;
    }
    // Display the current position. 
    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }

    readonly struct ReadOnlyPoint
    {
        // Fields of the structure. 
        public int X { get; }
        public int Y { get; }
        // Display the current position and name. 
        public void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
        public ReadOnlyPoint(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
    }
    // The readonly modifier can be applied to methods, properties, and property accessors
}

ref struct DisposableRefStruct
{
    public int X;
    public readonly int Y;
    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
    // A custom constructor.
    public DisposableRefStruct(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
        Console.WriteLine("Created!");
    }
    public void Dispose()
    {
        //clean up any resources here 
        Console.WriteLine("Disposed!");
    }
}
