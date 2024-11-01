using generic_list;

List <Person> people = new List<Person>()
{
    new Person {FirstName = "John", LastName = "Grus", Age = 32},
    new Person {FirstName = "Anna", LastName = "Rossi", Age = 29},
};

foreach (Person p in people)
{
    Console.WriteLine(p.FirstName);
    Console.WriteLine(p.LastName);
}

// generic lists are mutable
people.Insert(2, new Person {FirstName = "Lara", LastName = "Croft", Age = 40});
