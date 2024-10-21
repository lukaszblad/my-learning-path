using Constructors;

// Make a Car called Chuck going 10 MPH. 
Car chuck = new Car();
chuck.PrintState();
// Make a Car called Mary going 0 MPH. 
Car mary = new Car("Mary");
mary.PrintState();

// Make a Motorcycle with a rider named Tiny?
Motorcycle c = new Motorcycle();
c.SetDriverName("Tiny");
Console.WriteLine("Rider name is {0}", c.name); // Prints an empty name value!
