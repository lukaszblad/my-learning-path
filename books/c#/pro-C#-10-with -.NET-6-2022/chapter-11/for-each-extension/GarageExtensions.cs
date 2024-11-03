namespace for_each_extension;
using System.Collections;

static class GarageExtensions
{
    public static IEnumerator GetEnumerator(this Garage g)
    {
        return g.CarsInGarage.GetEnumerator();
    }
}
