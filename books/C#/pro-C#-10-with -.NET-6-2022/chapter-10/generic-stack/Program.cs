using generic_stack;

Stack<Person> stackOfPeople = new Stack<Person>();

stackOfPeople.Push(new Person {FirstName = "Lucio", LastName = "Taddi", Age = 32});

// Peek method returns the last added object
Console.WriteLine(stackOfPeople.Peek().FirstName);
