namespace for_each_extension;

public class Garage
{
    public Car[] CarsInGarage {get; set;}

    public Garage()
    {
        CarsInGarage = new Car[2];
        CarsInGarage[0] = new Car(99, "Rusty");
        CarsInGarage[1] = new Car(44, "Slowy");
    }
}
