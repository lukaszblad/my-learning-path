﻿using System.Reflection;

static void ListMethods(Type t)
{
    MethodInfo[] mi = t.GetMethods();
    foreach(MethodInfo m in mi)
    {
        Console.WriteLine("->{0}", m.Name);
    }
}

// Display property names of type.
static void ListProps(Type t)
{
    Console.WriteLine("***** Properties *****");
    var propNames = from p in t.GetProperties() orderby p.Name select p.Name;
    //var propNames = t.GetProperties().Select(p=>p.Name);
    foreach (var name in propNames)
    {
        Console.WriteLine("->{0}", name);
    }
    Console.WriteLine();
}

// Display field names of type.
static void ListFields(Type t)
{
    Console.WriteLine("***** Fields *****");
    // var fieldNames = from f in t.GetFields() orderby f.Name select f.Name;
    var fieldNames = t.GetFields().OrderBy(m=>m.Name).Select(x=>x.Name);
    foreach (var name in fieldNames)
    {
        Console.WriteLine("->{0}", name);
    }
    Console.WriteLine();
}

// Display implemented interfaces.
static void ListInterfaces(Type t)
{
    Console.WriteLine("***** Interfaces *****");
    var ifaces = from i in t.GetInterfaces() orderby i.Name select i;
    //var ifaces = t.GetInterfaces().OrderBy(i=>i.Name);
    foreach(Type i in ifaces)
    {
        Console.WriteLine("->{0}", i.Name);
    }
}

// Just for good measure.
static void ListVariousStats(Type t)
{
    Console.WriteLine("***** Various Statistics *****");
    Console.WriteLine("Base class is: {0}", t.BaseType);
    Console.WriteLine("Is type abstract? {0}", t.IsAbstract);
    Console.WriteLine("Is type sealed? {0}", t.IsSealed);
    Console.WriteLine("Is type generic? {0}", t.IsGenericTypeDefinition);
    Console.WriteLine("Is type a class type? {0}", t.IsClass);
    Console.WriteLine();
}

string? typeName = "";

do
{
    Console.WriteLine("\nEnter a typename do evaluate");
    Console.Write("Or enter Q to qui")  ;   
    typeName = Console.ReadLine();
    // Does user want to quit?
    if (typeName.Equals("Q",StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    try
    {
        Type t = Type.GetType(typeName);
        Console.WriteLine("");
        ListVariousStats(t);
        ListFields(t);
        ListProps(t);
        ListMethods(t);
        ListInterfaces(t);
    }
    catch
    {
        Console.WriteLine("Sorry, can't find type");
    }
} while(true);
