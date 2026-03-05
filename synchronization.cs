//class synchronization
//{
//    static object o = new object();
//    static void increment()
//    {
//        lock (o)
//        {
//            Console.WriteLine("Thread " + Thread.CurrentThread.Name + "thread is executing");
//        }
//    }
//    public static void Main(string[] args)
//    {
//        Thread t1 = new Thread(increment);
//        t1.Name = "First Thread";
//        Thread t2 = new Thread(increment);
//        t2.Name = "Second Thread";
//        t1.Start();
//        t2.Start();
//    }
//}

