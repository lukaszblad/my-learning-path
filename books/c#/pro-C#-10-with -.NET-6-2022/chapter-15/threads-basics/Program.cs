Console.ReadLine();

static void ExtraExecutingThread()
{
    // get the thread currently executing this method
    Thread currThread = Thread.CurrentThread;
}

static void ExtractAppDomainHostingThread()
{
    // obtain the AD hosting the current thread
    AppDomain ad = Thread.GetDomain();
}

static void ExtractCurrentThreadExecutionContext()
{
    // obtain the execution context under which the
    // current thread is operating
    ExecutionContext ctx = 
        Thread.CurrentThread.ExecutionContext;
}
