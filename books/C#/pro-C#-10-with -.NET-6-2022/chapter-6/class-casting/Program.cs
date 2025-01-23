using class_casting;

object myEmployee = new Employee();

// (ClassIWantToCastTo)referenceIHave

// C# provides the as keyword to quickly determine at runtime whether a given type is compatible with
// another
Employee h = myEmployee as Employee;
if (h == null)
{
    Console.WriteLine("not an Employee");
}
else
{
    Console.WriteLine("It's an Employee");
}

// the is keyword returns false, rather than a null reference, if
// the types are incompatible
if (myEmployee is Employee)
{
    Console.WriteLine("not an Employee");
}
else
{
    Console.WriteLine("It's an Employee");
}
