using System.Collections;
using linq_over_collections;

List <Car> myCars = new List<Car> {
    new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
    new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "Fiat"},
    new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
    new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
    new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
};

GetFastCars(myCars);
OfTypeAsFilter();

static void GetFastCars(List<Car> myCars)
{
    var subset = from c in myCars where c.Speed > 55 && c.Make == "BMW" select c;

    foreach (var c in subset)
    {
        Console.WriteLine("Car over 55: {0}", c.PetName);
    }
}

// filtering

static void OfTypeAsFilter()
{
    ArrayList myStuff = new ArrayList();
    myStuff.AddRange(new object[] {
        10,
        400,
        8,
        false,
        new Car(),
        "string data",
    });

    var myInts = myStuff.OfType<int>();

    foreach(int i in myInts)
    {
        Console.WriteLine(i);
    }
}
