namespace inheritance_in_detail;

public class Manager : Employee
{
    public Manager() {}

    // the base keyword is hanging off the constructor signature (much like the syntax used to chain 
    // constructors on a single class using the this keyword), which always 
    // indicates a derived constructor is passing data to the immediate parent constructor
    public Manager(string name, int age) : base(name, age) {}
}
