using System.Globalization;

QueryOverString();
QueryOverStringWithExtensionMethods();
QueryOverInts();

// LINQ queries can be used to iterate over data containers that implement
// the generic IEnumerable<T> interface

static void QueryOverString()
{
    string[] currentVideoGames = {
        "Morrowind",
        "Uncharted 2",
        "Fallout 3",
        "Dexter",
        "System Shock 2",
    };

    IEnumerable<string> subset = 
        from g in  currentVideoGames
        where g.Contains(' ')
        orderby g
        select g;

    foreach (string s in subset)
    {
        Console.WriteLine("Item: {0}", s);
    }
}

static void QueryOverStringWithExtensionMethods()
{
    string[] currentVideoGames = {
        "Morrowind",
        "Uncharted 2",
        "Fallout 3",
        "Dexter",
        "System Shock 2",
    };

    IEnumerable<string> subset = 
        currentVideoGames.Where(g => g.Contains(' ')).OrderBy(g => g).Select(g => g);

    foreach (string s in subset)
    {
        Console.WriteLine("Item: {0}", s);
    }
}

static void QueryOverInts()
{
    int[] numbers = {10, 20, 30, 40, 1, 2, 3, 8};

    // better to use implicit typing
    var subset = from i in numbers where i < 10 select i;

    foreach (var number in subset)
    {
        Console.WriteLine(number);
    }
}
