namespace lock_keyword;

public class Printer
{
    private object threadLock = new object();

    public void PrintNumbers()
    {
        // The C# lock statement is a shorthand notation for working with the System.Threading.Monitor
        lock(threadLock)
        {
            Console.WriteLine("-> {0} is executing PrintNumbers()",
                Thread.CurrentThread.Name);
            Console.Write("Your numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                Thread.Sleep(100 * r.Next(5));
                Console.Write("{0}, ", i);
            }
            Console.WriteLine();
        }
    }

    // USING Sys
    // public void PrintNumbers()
    // {
    //     Monitor.Enter(threadLock);
    //     try
    //     {
    //         // Display Thread info.
    //         Console.WriteLine("-> {0} is executing PrintNumbers()",
    //         Thread.CurrentThread.Name);
    //         // Print out numbers.
    //         Console.Write("Your numbers: ");
    //         for (int i = 0; i < 10; i++)
    //         {
    //             Random r = new Random();
    //             Thread.Sleep(1000 * r.Next(5));
    //             Console.Write("{0}, ", i);
    //         }
    //         Console.WriteLine();
    //     }
    //     finally
    //     {
    //         Monitor.Exit(threadLock);
    //     }
    // }
}
