using System.Diagnostics;

ListAllRunningProcesses();


static void ListAllRunningProcesses()
{
    var runningProcs = 
        from proc
        in Process.GetProcesses(".")
        orderby proc.Id
        select proc;

    foreach (var p in runningProcs)
    {
        Console.WriteLine($"-> PID: {p.Id}\tName: {p.ProcessName}");
    }
}

static void EnumThreadsForPid(int pID)
{
    Process theProc = null;
    try
    {
        theProc = Process.GetProcessById(pID);
    }
    catch(ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }

    Console.WriteLine("Here are the threads used by: {0}", theProc.ProcessName);
    ProcessThreadCollection theThreads = theProc.Threads;

    foreach(ProcessThread pt in theThreads)
    {
        string info = 
            $"-> Thread ID: {pt.Id}\tStart Time: {pt.StartTime.ToShortTimeString()}\tPriority {pt.PriorityLevel}";
        Console.WriteLine(info);
    }
}
