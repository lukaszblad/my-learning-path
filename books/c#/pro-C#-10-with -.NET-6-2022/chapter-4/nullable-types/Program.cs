// Value types can never be assigned the value of null, as that is used to establish an empty object reference.
// Compiler errors!
// Value types cannot be set to null! 
// bool myBool = null;
// int myInt = null;

//To define a nullable variable type, the question mark symbol (?) is suffixed to the underlying data typ.
static void LocalNullableVariables()
{
    // Define some local nullable variables. 
    int? nullableInt = 10;
    double? nullableDouble = 3.14;
    bool? nullableBool = null;
    char? nullableChar = 'a';
    int?[] arrayOfNullableInts = new int?[10];
}


// the ? notation is shorthand for Nullable<T>:
static void LocalNullableVariablesUsingNullable()
{
    // Define some local nullable types using Nullable<T>. 
    Nullable<int> nullableInt = 10;
    Nullable<double> nullableDouble = 3.14;
    Nullable<bool> nullableBool = null;
    Nullable<char> nullableChar = 'a';
    Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
}
