namespace object_overrides;

public class Person
{
    public string FirstName = "John";
    public int Age = 32;

    public override string ToString()
    {
        return $"First name: {FirstName}, Age: {Age}";
    }
}
