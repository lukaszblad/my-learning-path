using default_implementations;

DrawableObject myDrawableObject = new DrawableObject();

Console.WriteLine($"Object: {myDrawableObject.TimeToDraw()}");
Console.WriteLine($"Casted to interface: {((IDrawable)myDrawableObject).TimeToDraw()}");
