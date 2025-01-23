using System.Runtime.Serialization;
using simple_multithread_app;

Console.WriteLine("Do you want [1] or [2] threads?");
string threadCount = Console.ReadLine();

Thread primaryThread = Thread.CurrentThread;
primaryThread.Name = "Primary";

Console.WriteLine("-> {0} is executing Main()", Thread.CurrentThread.Name);

Printer p = new Printer();

switch(threadCount)
{
    case "2":
        Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
        backgroundThread.Name = "Secondary";
        backgroundThread.Start();
        break;
    case "1":
        p.PrintNumbers();
        break;
    default:
        goto case "1";
}

Console.WriteLine("This is on the main thread, and we are finished");
