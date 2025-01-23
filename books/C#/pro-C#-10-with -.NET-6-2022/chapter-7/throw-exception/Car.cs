using System.Security.Cryptography;

namespace throw_exception;

public class Car
{
    public int speed;
    public Car()
    {
        speed = 30;
    }
    public void SpeedUp()
    {
        if (speed >= 31)
        {
            throw new Exception("To fast");
        }
        speed++;
    }
}
