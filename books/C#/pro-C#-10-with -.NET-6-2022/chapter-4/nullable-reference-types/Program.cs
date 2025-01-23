string? nullableString = null;
TestClass? myNullableClass = null;

public class TestClass
{
    public string Name { get; set; }
    public int Age { get; set; }
}

#nullable disable
// non nullabe context
#nullable restore