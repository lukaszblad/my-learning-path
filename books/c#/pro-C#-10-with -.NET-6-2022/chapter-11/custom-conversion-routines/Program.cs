using custom_conversion_routines;

Rectangle myRectangle = new Rectangle(3, 4);

// converting explicitly Rectangle to Square
Square convertedRectangle  = (Square)myRectangle;


// converting implicitly Square to Rectangle
Square mySquare = new Square(5);
Rectangle convertedSquare = (Rectangle)mySquare;
