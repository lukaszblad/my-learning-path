using value_and_reference_types;

Point p1 = new Point();
Point p2 = p1;

p1.Display();
p2.Display();
p1.X = 100;
p1.Display();
p2.Display();