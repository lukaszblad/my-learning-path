using multi_threaded_printing;

Printer p = new Printer();

Thread[] threads = new Thread[10];
for (int i = 0; i < 10; i++)
{
    threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
    {
        Name = $"worker thread #{i}",
    };
}

foreach (Thread t in threads)
{
    t.Start();
}
