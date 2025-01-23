using System.Reflection;
using late_binding_with_dynamic;
using Microsoft.CSharp.RuntimeBinder;

AddWithReflection();
AddWithDynamic();

static void AddWithReflection()
{
    Type math = typeof(SimpleMath);
    object obj = Activator.CreateInstance(math);
    MethodInfo mi = math.GetMethod("Add");
    object[] args = {10, 70};
    Console.WriteLine("Result is: {0}", mi.Invoke(obj, args));
}

static void AddWithDynamic()
{
    Type math = typeof(SimpleMath);
    dynamic obj = Activator.CreateInstance(math);
    Console.WriteLine("Result is {0}", obj.Add(10, 70));
}
