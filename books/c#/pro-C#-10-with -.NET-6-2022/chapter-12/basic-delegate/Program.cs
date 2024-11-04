using basic_delegate;

Car myCar = new Car(30, 40, "Rusty");

myCar.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

for (int i = 0; i < 5; i++)
{
    myCar.Accelerate(5);
}

static void OnCarEngineEvent(string msg)
{
    Console.WriteLine(msg);
}
