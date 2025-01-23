namespace shadowing_new_keyword;

public class Circle : Shape
{
    // new keyword used to explicitly states that the derived type’s implementation is
    // intentionally designed to effectively ignore the parent’s version
    public new string Name = "Circle";
    public new void Draw()
    {
        Console.WriteLine("Draw a circle");
    }
}
