namespace building_exceptions;

public class CarIsDeadException : ApplicationException
{
    public override string Message => $"Car is Dead";
}
