Console.WriteLine("**** Fun with Enums *****");
// Make an EmpTypeEnum variable.
EmpTypeEnum emp = EmpTypeEnum.Contractor;
AskForBonus(emp);
// Print storage for the enum. 
Console.WriteLine("EmpTypeEnum uses a {0} for storage",
Enum.GetUnderlyingType(emp.GetType()));
// Enums as parameters.
static void AskForBonus(EmpTypeEnum e)
{
    switch (e)
    {
        case EmpTypeEnum.Manager:
            Console.WriteLine("How about stock options instead?");
            break;
        case EmpTypeEnum.Grunt:
            Console.WriteLine("You have got to be kidding...");
            break;
        case EmpTypeEnum.Contractor:
            Console.WriteLine("You already get enough cash...");
            break;
        case EmpTypeEnum.VicePresident:
            Console.WriteLine("VERY GOOD, Sir!");
            break;
    }
}
//local functions go here:
// A custom enumeration. 
enum EmpTypeEnum
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 9
}

// This time, EmpTypeEnum maps to an underlying byte. 
enum EmpTypeByteEnum : byte
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 9
}
