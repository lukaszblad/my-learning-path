// Invoking a delegate calls the method attached to the delegate instance
// The parameters passed to the delegate by the caller are passed to the method
// and the return value from the method is returned to the caller by the delegate
public class Program
{
    // Define the delegate at the class level
    public delegate void MyDelegate(string message);

    // Create a method for the delegate
    public static void MyDelegateMethod(string message)
    {
        Console.WriteLine(message);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Delegates");

        // Instantiate the delegate
        MyDelegate myHandler = MyDelegateMethod;

        // Call the delegate
        myHandler("Hello World");
    }
}

