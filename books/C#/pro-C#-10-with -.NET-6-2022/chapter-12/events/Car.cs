namespace events;

public class Car
{
    public int CurrSpd {get; set;}
    public int MaxSpd {get; set;}

    private bool _carIsDead;

    public Car(int currSpeed, int maxSpeed)
    {
        CurrSpd = currSpeed;
        MaxSpd = maxSpeed;
    }
    public delegate void CarEngineHandler(string msgForCaller);
    public event CarEngineHandler Exploded;
    public event CarEngineHandler AboutToBlow;

    public void Accelerate(int delta)
    {
        if (_carIsDead)
        {
            Exploded?.Invoke("Sorry this car is dead");
        }
        else
        {
            CurrSpd +=  delta;
            if (10 == MaxSpd - CurrSpd)
            {
                AboutToBlow?.Invoke("Gonna blow");
            }
            
            if (CurrSpd >= MaxSpd)
            {
                _carIsDead = true;
            }
            else
            {
                Console.WriteLine("CurrentSpeed = {0}", CurrSpd);
            }
        }
    }
}
