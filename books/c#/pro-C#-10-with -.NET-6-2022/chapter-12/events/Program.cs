using events;

Car myCar = new Car(30, 50);

// register event handlers
myCar.AboutToBlow += CarIsAlmostDoomed;
myCar.AboutToBlow += CarAboutToBlow;

Car.CarEngineHandler myCarEngineHandler = CarExploded;
myCar.Exploded += myCarEngineHandler;

for (int i = 0; i < 10; i++)
{
    myCar.Accelerate(5);
}

static void CarAboutToBlow(string msg)
{
    Console.WriteLine(msg);
}

static void CarIsAlmostDoomed(string msg)
{
    Console.WriteLine("Critical message: {0}", msg);
}

static void CarExploded(string msg)
{
    Console.WriteLine(msg);
}
