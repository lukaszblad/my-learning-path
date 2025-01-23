// anonymous types derive directly from System.Object
static object BuildAnonymousType(string make, string color, int currSp)
{
    var car = new {Make = make, Color = color, Speed = currSp};
    return car;
}

object myFirstCar = BuildAnonymousType("BMW", "Black", 90);
object mySecondCar = BuildAnonymousType("Fiat", "Blue", 80);

Console.WriteLine(myFirstCar.Equals(mySecondCar));
Console.WriteLine(myFirstCar.ToString());
