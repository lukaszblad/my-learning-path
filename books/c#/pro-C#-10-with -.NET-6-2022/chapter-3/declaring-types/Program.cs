DeclareExplicitVars();
DeclareImplicitVars();

static void DeclareExplicitVars()
{
    // Explicitly typed local variables
    // are declared as follows:
    // dataType variableName = initialValue; 
    int myInt = 0;
    bool myBool = true;
    string myString = "Time, marches on...";
}

static void DeclareImplicitVars()
{
    // Implicitly typed local variables. 
    var myInt = 0;
    var myBool = true;
    var myString = "Time, marches on...";
    // Print out the underlying type.
    Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
    Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
    Console.WriteLine("myString is a: {0}", myString.GetType().Name);
}
