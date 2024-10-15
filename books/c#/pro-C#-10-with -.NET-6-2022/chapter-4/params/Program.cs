// Return average of "some number" of doubles.
CalculateAverage(1, 3);
static double CalculateAverage(params double[] values)
{
    Console.WriteLine("You sent me {0} doubles.", values.Length);
    double sum = 0;
    if (values.Length == 0)
    {
        return sum;
    }
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    return (sum / values.Length);
}
