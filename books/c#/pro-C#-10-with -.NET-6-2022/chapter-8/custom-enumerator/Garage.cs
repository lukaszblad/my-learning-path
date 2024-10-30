namespace custom_enumerator;
using System.Collections;
using System.Runtime.CompilerServices;

public class Garage : IEnumerable
{
    // create array of cars
    private Car[] carArray = new Car[2];
    // built-in array getenumerator
    public IEnumerator GetEnumerator() => carArray.GetEnumerator();
}
