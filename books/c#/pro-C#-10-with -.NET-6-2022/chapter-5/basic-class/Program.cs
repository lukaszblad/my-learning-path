using basic_class;
// Allocate and configure a Car object.
// As shown in the previous code example, objects must be allocated into memory using the new keyword. If 
// // you do not use the new keyword and attempt to use your class variable in a subsequent code statement, you 
will receive a compiler error. For example, the following top-level statement will not compile:
Car myCar = new Car();
myCar.petName = "Henry";
myCar.currSpeed = 10;
// Speed up the car a few times and print out the 
// new state.
for (int i = 0; i <= 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}
Console.ReadLine();
