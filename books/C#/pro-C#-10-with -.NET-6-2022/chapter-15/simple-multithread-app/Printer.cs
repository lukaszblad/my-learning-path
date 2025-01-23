namespace simple_multithread_app;

public class Printer
{
    public void PrintNumbers()
    {
        // display thread info
        Console.WriteLine("-> {0} is executing PrintNumbers", Thread.CurrentThread.Name);
        // print out numbers
        Console.Write("Your numbers: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("{0}", i);
            Thread.Sleep(2000);
        }
        Console.WriteLine();
    }
}
