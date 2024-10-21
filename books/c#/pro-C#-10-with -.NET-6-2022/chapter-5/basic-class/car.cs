namespace basic_class
{
    class Car
    {
        // The 'state' of the Car. 
        public string petName;
        public int currSpeed;
        // The functionality of the Car.
        // Using the expression-bodied member syntax 
        // covered in Chapter 4
        public void PrintState()
          => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        public void SpeedUp(int delta)
          => currSpeed += delta;
    }
}
