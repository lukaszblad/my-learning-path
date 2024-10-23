using inheritance_in_detail;

Employee myEmployee = new Employee("Sebastian", 32);
Console.WriteLine($"Name: {myEmployee.Name}, Age: {myEmployee.Age}");

SalesPerson mySalesPerson = new SalesPerson
{
    Name = "Toby", Age = 31
};

Console.WriteLine($"Name: {mySalesPerson.Name}, Age: {mySalesPerson.Age}");
Console.WriteLine(SalesPerson.SalesPersonAccesses());
