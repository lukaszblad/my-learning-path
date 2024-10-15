// Output parameters must be assigned by the called method. 
int ans1;
AddUsingOutParam(90, 90, out ans1);
AddUsingOutParam(90, 90, out int ans2);
FillTheseValues(out int i, out string str, out bool b);
Console.WriteLine(ans1);
Console.WriteLine(ans2);
Console.WriteLine(i);
Console.WriteLine(str);
Console.WriteLine(b);

//This only gets the value for a, and ignores the other two parameters 
FillTheseValues(out int a, out _, out _);
Console.WriteLine(a);

static void AddUsingOutParam(int x, int y, out int ans)
{
    ans = x + y;
}

// Reurning multiple output parameters.
static void FillTheseValues(out int a, out string b, out bool c)
{
    a = 9;
    b = "Enjoy your string.";
    c = true;
}
