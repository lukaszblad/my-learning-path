using for_each_extension;

Garage myGarage = new Garage();

foreach  (Car c in myGarage)
{
    Console.WriteLine(c.PetName);
}
