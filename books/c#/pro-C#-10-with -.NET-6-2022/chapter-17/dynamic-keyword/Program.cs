// dynamic variables are not strongly typed (at compile time).
ChangeDynamicDataType();

static void ChangeDynamicDataType()
{
    dynamic dynamicVariable = "Hello!";
    Console.WriteLine("type is: {0}", dynamicVariable.GetType());
    dynamicVariable = false;
    Console.WriteLine("type is: {0}", dynamicVariable.GetType());
    dynamicVariable = new List<int>();
    Console.WriteLine("type is: {0}", dynamicVariable.GetType());
}
    