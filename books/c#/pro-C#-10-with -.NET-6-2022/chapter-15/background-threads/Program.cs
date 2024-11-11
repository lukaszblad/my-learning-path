using background_threads;

Printer p = new Printer();
Thread bgroundThread = new Thread(new ThreadStart(p.PrintNumbers));

// setting thread to background
bgroundThread.IsBackground = true;
bgroundThread.Start();  
