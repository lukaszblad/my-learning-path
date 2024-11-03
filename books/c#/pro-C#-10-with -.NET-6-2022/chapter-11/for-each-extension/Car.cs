namespace for_each_extension;

public class Car
{
    public int CurrentSpeed {get; set;} = 0;
    public string PetName {get; set;} = "";

    public Car(int speed, string name)
    {
        CurrentSpeed = speed;
        PetName = name;
    }
}
