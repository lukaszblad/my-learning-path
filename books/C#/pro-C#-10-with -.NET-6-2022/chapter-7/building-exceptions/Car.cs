namespace building_exceptions;

public class Car
{
    public Car() {}
    public void Accelerate()
    {
        throw new CarIsDeadException();
    }

    public void DontRefill()
    {
        throw new OutOfFuelEception("Out of fuel");
    }
}
