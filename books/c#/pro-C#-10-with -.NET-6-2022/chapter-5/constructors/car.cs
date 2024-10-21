using System.Security.Cryptography.X509Certificates;

namespace Constructors
{
    class Car
    {
        // The 'state' of the Car. 
        public string petName;
        public int currSpeed;
        // A custom default constructor. 
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }
        // Here, currSpeed will receive the 
        // default value of an int (zero). 
        public Car(string pn)
        {
            petName = pn;
        }
        // Let caller set the full state of the Car. 
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        public void PrintState()
            => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
    }

    class Motorcycle
    {
        public Motorcycle()
        {
            
        }
        public string name;
        public void SetDriverName(string name)
        {
            this.name = name;
        }
    }
}
