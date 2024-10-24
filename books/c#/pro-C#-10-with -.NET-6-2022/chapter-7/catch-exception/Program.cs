using catch_exception;

Car myCar = new Car();

try
{
    myCar.SpeedUp();
}
catch(Exception e)
{
    throw new Exception("To fast");
}
Console.WriteLine(myCar.speed);
myCar.SpeedUp();