Console.WriteLine("Working with timer type");

static void PrintTime(object state)
{
    Console.WriteLine("Time is: {0}", DateTime.Now.ToLongTimeString());
}

TimerCallback timeCB = new TimerCallback(PrintTime);

Timer t = new Timer(timeCB, null, 0, 1000);

Console.WriteLine("Hit enter to stop");
Console.ReadLine();
