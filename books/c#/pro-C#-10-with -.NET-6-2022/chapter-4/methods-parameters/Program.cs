// When a parameter does not have a modifier, the behavior for value types is to pass in the parameter by value 
// and for reference types is to pass in the parameter by reference.
MethodsParameters();

static void MethodsParameters()
{
    int x = 9, y = 10;
    Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
    Console.WriteLine("Answer is: {0}", Add(x, y));
    Console.WriteLine("After call: X: {0}, Y: {1}", x, y);

    static int Add(int x, int y)
    {
        int ans = x + y;
        // Caller will not see these changes 
        // as you are modifying a copy of the 
        // original data.
        x = 10000;
        y = 88888;
        return ans;
    }
}
