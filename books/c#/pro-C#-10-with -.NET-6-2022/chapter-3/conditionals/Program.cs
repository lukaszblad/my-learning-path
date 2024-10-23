IfElsePatternMatching();
IfElsePatternMatchingUpdatedInCSharp9();
ExecuteIfElseUsingConditionalOperator();
ConditionalRefExample();

static void IfElsePatternMatching()
{
    Console.WriteLine("===If Else Pattern Matching ===");
    object testItem1 = 123;
    object testItem2 = "Hello";
    if (testItem1 is string myStringValue1)
    {
        Console.WriteLine($"{myStringValue1} is a string");
    }
    if (testItem1 is int myValue1)
    {
        Console.WriteLine($"{myValue1} is an int");
    }
    if (testItem2 is string myStringValue2)
    {
        Console.WriteLine($"{myStringValue2} is a string");
    }
    if (testItem2 is int myValue2)
    {
        Console.WriteLine($"{myValue2} is an int");
    }
    Console.WriteLine();
}

static void IfElsePatternMatchingUpdatedInCSharp9()
{
    Console.WriteLine("======= C# 9 If Else Pattern Matching Improvements =======");
    object testItem1 = 123;
    Type t = typeof(string);
    char c = 'f';
    //Type patterns 
    if (t is Type)
    {
        Console.WriteLine($"{t} is a Type");
    }
    //Relational, Conjuctive, and Disjunctive patterns 
    if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
    {
        Console.WriteLine($"{c} is a character");
    };
    //Parenthesized patterns
    if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
    {
        Console.WriteLine($"{c} is a character or separator");
    };
    //Negative patterns
    if (testItem1 is not string)
    {
        Console.WriteLine($"{testItem1} is not a string");
    }
    if (testItem1 is not null)
    {
        Console.WriteLine($"{testItem1} is not null");
    }
    Console.WriteLine();
}

// Ternary operator
// condition ? first_expression : second_expression;
// works only with assignent statements
static void ExecuteIfElseUsingConditionalOperator()
{
    string stringData = "My textual data";
    Console.WriteLine(stringData.Length > 0
      ? "string is greater than 0 characters"
      : "string is not greater than 0 characters");
    Console.WriteLine();
}

static void ConditionalRefExample()
{
    var smallArray = new int[] { 1, 2, 3, 4, 5 };
    var largeArray = new int[] { 10, 20, 30, 40, 50 };
    int index = 7;
    ref int refValue = ref ((index < 5)
      ? ref smallArray[index]
      : ref largeArray[index - 5]);
    refValue = 0;
    index = 2;
    ((index < 5)
      ? ref smallArray[index]
      : ref largeArray[index - 5]) = 100;
    Console.WriteLine(string.Join(" ", smallArray));
    Console.WriteLine(string.Join(" ", largeArray));
}
