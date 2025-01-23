Console.WriteLine("***** Fun with Methods *****");
EnterLogData("Oh no! Grid can't find data");
EnterLogData("Oh no! I can't find the payroll data", "CFO");

// optional parameters have to be specified at compile time.
// runtime parameters, such as date.now, will cause a compile-time error
static void EnterLogData(string message, string owner = "Programmer")
{
    Console.WriteLine("Error: {0}", message);
    Console.WriteLine("Owner of Error: {0}", owner);
}
