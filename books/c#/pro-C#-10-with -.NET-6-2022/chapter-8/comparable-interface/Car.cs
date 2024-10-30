namespace comparable_interface;

// to sort, needed to implement the comparable interface
public class Car : IComparable
{
    private int CarID = 0;
    int IComparable.CompareTo(object? obj)
    {
        if (obj is Car temp)
        {
            if (this.CarID > temp.CarID)
            {
                return 1;
            }
            if (this.CarID < temp.CarID)
            {
                return -1;
            }
            return 0;
        }
        throw new ArgumentException("Not a car");
    }
}
