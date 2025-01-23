using threads_with_parameters;

void Add(object data)
{
    if (data is AddParams ap)
    {
        Console.WriteLine("ID of thread in Add(): {0}", Environment.CurrentManagedThreadId);
        Console.WriteLine("{0} + {1} is {2}", ap.a, ap.b, ap.a + ap.b);
    }
}

Console.WriteLine("ID of thread in Main(): {0}", Environment.CurrentManagedThreadId);
AddParams ap = new AddParams(10, 10);
Thread t = new Thread(new ParameterizedThreadStart(Add));
t.Start(ap);

Thread.Sleep(5);
