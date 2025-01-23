namespace custom_interfaces;

public interface IPointy
{
    // int GetNumberOfPoints();
    int Points {get;}

    public void DefaultMethod()
    {
        Console.WriteLine("To use this method objects need to be cast to IPointy");
    }
}
