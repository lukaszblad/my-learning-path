BasicStringFunctionality();
StringConcatenation();
StringInterpolation();
StringsAreImmutable();

static void BasicStringFunctionality()
{
    Console.WriteLine("=> Basic String functionality:");
    string firstName = "Freddy";
    Console.WriteLine("Value of firstName: {0}", firstName);
    Console.WriteLine("firstName has {0} characters.", firstName.Length);
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
    Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
    Console.WriteLine("firstName contains the letter y?: {0}",
      firstName.Contains("y"));
    Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
    Console.WriteLine();
}

static void StringConcatenation()
{
    Console.WriteLine("=> String concatenation:");
    string s1 = "Programming the ";
    string s2 = "PsychoDrill (PTP)";
    string s3 = s1 + s2;
    Console.WriteLine(s3);
    Console.WriteLine();
}

static void StringInterpolation()
{
    Console.WriteLine("=> String interpolation:\a");
    // Some local variables we will plug into our larger string 
    int age = 4;
    string name = "Soren";
    // Using curly-bracket syntax.
    string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
    Console.WriteLine(greeting);
    // Using string interpolation
    string greeting2 = $"Hello {name} you are {age} years old.";
    Console.WriteLine(greeting2);

    string interp = "interpolation";
    string myLongString = $@"This is a very
         long string with {interp}";
    Console.WriteLine(myLongString);
}

static void StringsAreImmutable()
{
    Console.WriteLine("=> Immutable Strings:\a");
    // Set initial string value.
    string s1 = "This is my string.";
    Console.WriteLine("s1 = {0}", s1);
    // Uppercase s1?
    string upperString = s1.ToUpper();
    Console.WriteLine("upperString = {0}", upperString);
    // Nope! s1 is in the same format! 
    Console.WriteLine("s1 = {0}", s1);
}
