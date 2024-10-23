using object_overrides;

Person myPerson = new Person();

// Use inherited members of System.Object.
Console.WriteLine("ToString: {0}", myPerson.ToString());
Console.WriteLine("Hash code: {0}", myPerson.GetHashCode());
Console.WriteLine("Type: {0}", myPerson.GetType());
// Make some other references to p1.
Person p2 = myPerson;
object o = p2;
// Are the references pointing to the same object in memory?
if (o.Equals(myPerson) && p2.Equals(o))
{
    Console.WriteLine("Same instance!");
}