for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine(args[i]);
}

foreach(string arg in args)
{
    Console.WriteLine(arg);
}

// access args
string[] theArgs = Environment.GetCommandLineArgs();
foreach(string arg in theArgs)
{
    Console.WriteLine(arg);
}
