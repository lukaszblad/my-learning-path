// the directory type classes usually return a string value
// instead of a directory info object

Example();

static void Example()
{
    string[] drives = Directory.GetLogicalDrives();
    Console.WriteLine("Here are your drives:");
    foreach (string s in drives)
    {
        Console.WriteLine("--> {0}", s);
    }
}
