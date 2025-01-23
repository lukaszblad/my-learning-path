using sorted_set;

SortedSet <Person> sortedPeople = new SortedSet<Person>(new SortPeopleByAge())
{
    new Person {Name = "John", Age = 29},
    new Person {Name = "Anna", Age = 22},
};

foreach(Person p in sortedPeople)
{
    Console.WriteLine(p.Age);
}
