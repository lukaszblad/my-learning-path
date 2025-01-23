namespace formalized_disposable_pattern;

class MyResourceWrapper : IDisposable
{
    private bool _disposed = false;
    public void Dispose()
    {
        Console.WriteLine("Disposing");
    }

    private void CleanUp(bool disposing)
    {
        if (!this._disposed)
        {
            if (disposing)
            {
                Console.WriteLine("Disposing");
            }
            Console.WriteLine("Cleaning up resources");
        }
        _disposed = true;
    }

    ~MyResourceWrapper()
    {
        CleanUp(false);
    }
}
