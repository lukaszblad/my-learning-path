LambdaExpressionSyntax();

static void LambdaExpressionSyntax()
{
    List<int> list = new List<int>();
    list.AddRange(new int[] {20, 1, 4, 8, 9, 44});
    List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);
    foreach (int evenNumber in evenNumbers)
    {
        Console.WriteLine(evenNumber);
    }
}