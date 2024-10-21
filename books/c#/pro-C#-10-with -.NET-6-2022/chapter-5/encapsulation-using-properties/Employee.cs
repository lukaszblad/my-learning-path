using static System.Net.Mime.MediaTypeNames;

namespace EmployeeApp;

class Employee
{
    // Field data.
    private string _empName;
    private int _empId;
    private float _currPay;
    private int _empAge;
    // Constructors.
    public Employee() { }
    public Employee(string name, int id, float pay)
    {
        _empName = name;
        _empId = id;
        _currPay = pay;
    }
    // Methods.
    public void GiveBonus(float amount) => _currPay += amount;
    public void DisplayStats()
    {
        Console.WriteLine("Name: {0}", _empName);
        Console.WriteLine("ID: {0}", _empId);
        Console.WriteLine("Pay: {0}", _currPay);
    }
    // Properties!
    public string Name
    {
        get { return _empName; }
        set
        {
            if (value.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                _empName = value;
            }
        }
    }
    // We could add additional business rules to the sets of these properties; 
    // however, there is no need to do so for this example.
    public int Id
    {
        get { return _empId; }
        set { _empId = value; }
    }
    public float Pay
    {
        get { return _currPay; }
        set { _currPay = value; }
    }

    public int Age
    {
        get => _empAge;
        set => _empAge = value;
    }
}
