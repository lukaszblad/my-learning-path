namespace using_declaration;

public class MyResourceWrapper : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("Disposing");
    }
}
