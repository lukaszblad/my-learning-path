namespace AutoProps;
class Car
{
    // a class doesn't need private fields for properties like PetName when you're using automatic properties.The compiler generates them for you!

    // Automatic properties! No need to define backing fields. 
    public string PetName { get; set; }
    public int Speed { get; set; }
    public string Color { get; set; }

    // Read-only property? This is OK! 
    public int MyReadOnlyProp { get; }
    // Write only property? Error! 
    // public int MyWriteOnlyProp { set; }
}
