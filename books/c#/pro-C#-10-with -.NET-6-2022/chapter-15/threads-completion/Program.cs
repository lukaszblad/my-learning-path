using threads_completion;

AutoResetEvent _waitHandle = new AutoResetEvent(false);

Console.WriteLine("ID of thread in Main(): {0}", Environment.CurrentManagedThreadId);
AddParams ap = new AddParams(10, 10);
Thread t = new Thread(new ParameterizedThreadStart(Add));
t.Start(ap);

_waitHandle.WaitOne();
Console.WriteLine("Other thread is done");

void Add(object data)
{
    if (data is AddParams ap)
    {
        Console.WriteLine("ID of thread in Add(): {0}", Environment.CurrentManagedThreadId);
        Console.WriteLine("{0} + {1} = {2}", ap.a, ap.b, ap.a + ap.b);
    }

    // tell other thread we are done
    _waitHandle.Set();
}
