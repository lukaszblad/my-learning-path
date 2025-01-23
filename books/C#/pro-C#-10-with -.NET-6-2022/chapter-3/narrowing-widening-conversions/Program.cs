ProcessBytes();

static int Add(int x, int y)
{
    return x + y;
}

// To handle overflow or underflow conditions in your application, use the checked keyword
static void ProcessBytes()
{
    byte b1 = 100;
    byte b2 = 250;
    // This time, tell the compiler to add CIL code 
    // to throw an exception if overflow/underflow 
    // takes place.
    try
    {
        byte sum = checked((byte)Add(b1, b2));
        Console.WriteLine("sum = {0}", sum);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
