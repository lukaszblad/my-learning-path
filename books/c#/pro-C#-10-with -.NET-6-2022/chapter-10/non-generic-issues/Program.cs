using System.Collections;

Console.WriteLine("Issues of non-generic collections");
SimpleBoxUnboxOperation();

static void SimpleBoxUnboxOperation()
{
    int myInt = 25;

    // box the int into an object reference
    // boxing: assining value type to a System.Object
    // it will be copied to the heap
    object boxedInt = myInt;

    // unboxing the int
    int unboxedInt = (int)boxedInt;

    // non generic collections stores object types
    // so data like int has to be boxed to be stored in an array list
    // then has to be unboxed to be used.
    ArrayList myArrayList = new ArrayList();
    myArrayList.Add(10); // boxing
    int i = (int)myArrayList[0]; // unboxing

    // type safety can also be an issue due to the fact that storing
    // object types, non generic collections can basically store everything
    myArrayList.Add("test");
    myArrayList.Add(true);
}
