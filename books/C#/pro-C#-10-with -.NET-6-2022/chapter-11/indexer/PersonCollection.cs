using System.Collections;

namespace indexer;

public class PersonCollection<Person> : IEnumerable
{
    private ArrayList arPeople = new ArrayList();

    public IEnumerator GetEnumerator()
    {
        foreach (Person p in arPeople)
        {
            yield return p;
        }
    }

    // indexer
    public Person this[int index]
    {
        get => (Person)arPeople[index];
        set => arPeople.Insert(index, value);
    }

    // when using a dictionary, the indexer property can also be set to
    // accept strings
    // public Person this[string name]
}
