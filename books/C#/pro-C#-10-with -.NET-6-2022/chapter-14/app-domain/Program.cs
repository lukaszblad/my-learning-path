DisplayDADStats();

static void DisplayDADStats()
{
    // Get access to the AppDomain for the current thread.
    AppDomain defaultAD = AppDomain.CurrentDomain;
    // Print out various stats about this domain.
    Console.WriteLine("Name of this domain: {0}",
    defaultAD.FriendlyName);
    Console.WriteLine("ID of domain in this process: {0}",
    defaultAD.Id);
    Console.WriteLine("Is this the default domain?: {0}",
    defaultAD.IsDefaultAppDomain());
    Console.WriteLine("Base directory of this domain: {0}",
    defaultAD.BaseDirectory);
    Console.WriteLine("Setup Information for this domain:");
    Console.WriteLine("\t Application Base: {0}",
    defaultAD.SetupInformation.ApplicationBase);
    Console.WriteLine("\t Target Framework: {0}",
    defaultAD.SetupInformation.TargetFrameworkName);
}   