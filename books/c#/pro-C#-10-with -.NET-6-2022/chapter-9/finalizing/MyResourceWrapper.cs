namespace finalizing;

class MyResourceWrapper
{
    // finalizer syntax
    // it takes 2 gc to finalize an object
    ~MyResourceWrapper() => Console.WriteLine("Finalizing");
}
