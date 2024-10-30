namespace default_implementations;

public class DrawableObject : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Draw Object");
    }
    public int TimeToDraw() => 8;
}
