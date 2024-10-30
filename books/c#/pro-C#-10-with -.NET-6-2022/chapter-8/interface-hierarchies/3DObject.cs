namespace interface_hierarchies;

public class _3DObject : AdvancedDraw
{
    public void Draw()
    {
        Console.WriteLine("Draw");
    }

    public void AdvancedDraw()
    {
        Console.WriteLine("Advanced Draw");
    }
}
