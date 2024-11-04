namespace basic_delegate;

public class Car
{
    public int CurrSpeed {get; set;}
    public int MaxSpeed {get; set;} = 50;
    public string PetName {get; set;}
    private bool _CarIsDead;
    public Car(int s, int ms, string name)
    {
        CurrSpeed= s;
        MaxSpeed = ms;
        PetName = name;
    }

    public void Accelerate(int delta)
    {
        if (_CarIsDead)
        {
            // IV. invoke the methods via a call to Invoke() on the delegate object
            _listOfHandlers?.Invoke("Sorry, this car is dead");
        }
        else
        {
            CurrSpeed += delta;
            if (10 == (MaxSpeed - CurrSpeed))
            {
                _listOfHandlers?.Invoke("Careful! Gonna blow?");
            }
            if (CurrSpeed >= MaxSpeed)
            {
                _CarIsDead = true;
            }
            else
            {
                Console.WriteLine("Current speed: {0}", CurrSpeed);
            }
        }
    }

    // I. define a custom delegate
    public delegate void CarEngineHandler(string msgForCaller);
    // II. Create an instance of the custom delegate
    private CarEngineHandler _listOfHandlers;
    // III. register methods to call
    public void RegisterWithCarEngine(CarEngineHandler methodToCall)
    {
        _listOfHandlers = methodToCall;
        // for multicasting use the += overloaded operator
    }
}
