namespace building_exceptions;

public class OutOfFuelEception : ApplicationException
{
    // feed message to parent constructor
    public OutOfFuelEception(string message) : base(message) {}
}
