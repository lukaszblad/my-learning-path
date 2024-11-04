DisplayNumber display = delegate (int num)
{
    Console.WriteLine("Number: {0}", num);
};

display(10);

delegate void DisplayNumber(int number);

