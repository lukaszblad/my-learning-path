using System.Collections.ObjectModel;
using observable_collection;
using System.Collections.Specialized;

ObservableCollection <Person> people = new ObservableCollection<Person>()
{
    new Person {Name = "John", Age = 34},
    new Person {Name = "Anna", Age = 29},
};

people.CollectionChanged += people_CollectionChanged;

static void people_CollectionChanged(object sender,
    NotifyCollectionChangedEventArgs e)
{
    // What was the action that caused the event?
    Console.WriteLine("Action for this event: {0}", e.Action);
    Console.WriteLine(e.Action.GetType());
    // They removed something.
    // if (e.Action == )
    // {
    //     Console.WriteLine("Here are the OLD items:");
    //     foreach (Person p in e.OldItems)
    //     {
    //         Console.WriteLine(p.ToString());
    //     }
    //     Console.WriteLine();
    // }
    // // They added something.
    // if (e.Action == NotifyCollectionChangedAction.Add)
    // {
    //     // Now show the NEW items that were inserted.
    //     Console.WriteLine("Here are the NEW items:");
    //     foreach (Person p in e.NewItems)
    //     {
    //         Console.WriteLine(p.ToString());
    //     }
    // }
}

people.Add(new Person {Name = "Lello", Age = 60});

