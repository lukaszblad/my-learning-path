namespace disposable;

class MyResourceWrapper : IDisposable
{
    // has to be called manually, will not be called by the GC
    public void Dispose()
    {
        Console.WriteLine("Dispose");
    }
}
