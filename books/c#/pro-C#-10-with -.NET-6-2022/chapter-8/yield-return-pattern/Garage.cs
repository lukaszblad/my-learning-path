namespace yield_return_pattern;
using System.Collections;

public class Garage : IEnumerable
{
    private Car[] carArray = new Car[4];

    public IEnumerator GetEnumerator()
    {
        foreach (Car car in carArray)
        {
            yield return car;
        }
    }
}
