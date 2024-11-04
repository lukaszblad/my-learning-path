// target for the action delegate
static void DisplayMessage(string msg)
{
 Console.WriteLine("Action message: {0}", msg);   
}

// action delegates can be used only for methods that return void
Action<string> actionTarget = DisplayMessage;
actionTarget("using an action delegate");

// target for func delegate
static int Adding(int x, int y)
{
    return x + y;
}

static string SumToString(int x, int y)
{
    return (x + y).ToString();
}

// func delegates can return a value
Func<int, int, int> funcTarget = Adding;
int result = funcTarget.Invoke(40, 40);

Func<int, int, string> funcTarget2 = SumToString;
string sum = funcTarget2(50, 50);
Console.WriteLine(sum);
