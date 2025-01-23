using dictionary;

Dictionary<string, Person> peopleDictionary = new Dictionary<string, Person>();
peopleDictionary.Add("Manager", new Person {Name = "John", Age = 20});
Person myManager = peopleDictionary["Manager"];
