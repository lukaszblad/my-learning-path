IndecesAndRanges();

static void IndecesAndRanges()
{
    string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

    Console.WriteLine("====Index=====");
    for (int i = 0; i < gothicBands.Length; i++)
    {
        Index idx = i;
        // Print a name 
        Console.Write(gothicBands[idx] + ", \n");
    }

    Console.WriteLine("=====Reversed Index=====");
    for (int i = 1; i <= gothicBands.Length; i++)
    {
        Index idx = ^i;
        Console.WriteLine(idx);
        // Print a name 
        Console.Write(gothicBands[idx] + ", \n");
    }

    Console.WriteLine("RANGES");
    foreach (var itm in gothicBands[0..2])
    {
        // Print a name 
        Console.Write(itm + ", ");
    }
    Console.WriteLine("\n");

    Range r = 0..2; //the end of the range is exclusive 
    foreach (var itm in gothicBands[r])
    {
        // Print a name 
        Console.Write(itm + ", ");
    }
    Console.WriteLine("\n");
}