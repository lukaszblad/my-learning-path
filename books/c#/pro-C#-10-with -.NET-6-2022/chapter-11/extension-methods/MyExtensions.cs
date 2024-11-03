namespace extension_methods;

// extensions needs to be declared as static
static class MyExtensions
{
    public static void DisplayItem(this object obj)
    {
        Console.WriteLine(obj);
    }

    // this method will be extended only for object which class implements IEnumerable
    public static void ExtensionForIEnumerable(this System.Collections.IEnumerable iterator)
    {
        Console.WriteLine("I implement IEnumerable");
    }
}
