//class porperties_thread //1. Thread Properties
//{
//    static void displayname() //2. Method for thread
//    {
//        Console.WriteLine("Thread is executing");

//        Console.WriteLine("Thread Name: " + Thread.CurrentThread.Name);
//        Console.WriteLine("Thread ID: " + Thread.CurrentThread.ManagedThreadId);
//        Console.WriteLine("Thread State: " + Thread.CurrentThread.ThreadState);
//    }
//    public static void Main(string[] args)
//    {

//        Thread t1 = new Thread(displayname); //3. Create thread object and pass method name as parameter
//        Console.WriteLine(t1.ThreadState);
//        t1.Name = "First Thread";
//        t1.Start();
//        Console.WriteLine(t1.ThreadState);
//        t1.Priority = ThreadPriority.Highest;
//        Console.WriteLine("first Thread Priority: " + t1.Priority);

//        Console.WriteLine(":) :) :) :) :) :( :( :( :( :( ");

//        Thread t2 = new Thread(displayname);
//        t2.Name = "Second Thread";
//        t2.Start();
//        t2.Priority = ThreadPriority.Lowest;    
//        Console.WriteLine("Second Thread Priority: " + t2.Priority);
//        Console.WriteLine("thread t2 is alive???"+t2.IsAlive);
//        Console.WriteLine("thread t1 is alive???"+t1.IsAlive); //
//        Console.WriteLine("thread t1 is background thread???"+t1.IsBackground);

//    }
//}

