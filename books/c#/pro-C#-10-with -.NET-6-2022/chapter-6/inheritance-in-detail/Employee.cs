namespace inheritance_in_detail;

public class Employee
{
    private string _name;
    private int _age;

    public string Name
    {
        get {return _name;}
        set
        {
            if(!string.IsNullOrEmpty(value))
            {
                _name = value;
            }
            else
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }
        }
    }

    public int Age
    {
        get {return _age;}
        set
        {
            if (value >= 0)
            {
                _age = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Age must be non-negative.");
            }
        }
    }

    public Employee()
    {
        _name = "Unknown";
        _age = 0;
    }
    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }
}