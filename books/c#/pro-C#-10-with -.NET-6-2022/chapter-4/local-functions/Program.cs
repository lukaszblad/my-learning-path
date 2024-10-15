//A local function is a function declared inside another function, must be private, with C# 8.0 can be static
ExampleLocalFunction();
AddWrapperWithStatic(3, 7);

static void ExampleLocalFunction()
{
    Console.Write(AddWrapper(2, 3));
    static int AddWrapper(int x, int y)
    {
        //Do some validation here 
        return Add();
        int Add()
        {
            return x + y;
        }
    }
}

static int AddWrapperWithStatic(int x, int y)
{
    //Do some validation here 
    return Add(x, y);
    // implementing the local function as static, prevents side-effects
    // as static functions cannot access outer method's variables directly
    static int Add(int x, int y)
    {
        return x + y;
    }
}