using System.Numerics;

LocalVarDeclarations();
DefaultDeclarations();
NewingDataTypes();

static void LocalVarDeclarations()
{
    int myInt;
    string myString;
    bool b1=true, b2=false, b3 = b1;
}

static void DefaultDeclarations()
{
    Console.WriteLine("=> Default Declarations:");
    int myInt = default;
    int myString = default;
    Console.WriteLine("default int:{0}, defaultString:{1}", myInt, myString);
}
static void NewingDataTypes()
{
    Console.WriteLine("=> Using new to create variables:");
    bool b = new bool();              // Set to false.
    int i = new int();                // Set to 0.
    double d = new double();          // Set to 0.
    DateTime dt = new DateTime();     // Set to 1/1/0001 12:00:00 AM 
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();

    Console.WriteLine("=> Using new to create variables:");
    bool b1 = new();              // Set to false.
    int i1 = new();               // Set to 0.
    double d1 = new();            // Set to 0.
    DateTime dt1 = new();         // Set to 1/1/0001 12:00:00 AM
    Console.WriteLine("{0}, {1}, {2}, {3}", b1, i1, d1, dt1);
    Console.WriteLine();
}
