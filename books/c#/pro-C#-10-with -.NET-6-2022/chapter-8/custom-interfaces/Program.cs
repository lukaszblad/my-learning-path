using custom_interfaces;

Square mySquare = new Square();
Console.WriteLine(mySquare.Points);

Circle myCircle = new Circle();
IPointy? myIpointy = null;
try
{
    myIpointy = (IPointy)myCircle;
}
catch (InvalidCastException e)
{
    Console.WriteLine("Circle doesn't implement Points");
}

IPointy? myIpointy2 = myCircle as IPointy;
if (myIpointy2 != null)
{
    Console.WriteLine("implements Points");
}
else
{
    Console.WriteLine("Doesn't implements Points");
}

if (myCircle is IPointy myIpointy3)
{
    Console.WriteLine("implements Points");
}
else
{
    Console.WriteLine("Doesn't implement Points");
}
