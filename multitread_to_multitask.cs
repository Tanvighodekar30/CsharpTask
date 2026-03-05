//Multi - Task to Multi-Thread

// Multiple tasks
// Each task runs on separate thread

//Example:

//Thread 1 → Reverse numbers

//Thread 2 → Series

//Thread 3 → Table



//class multitread_to_multitask
// {
//    static void reverse()
//    {
//        for (int i = 0; i >=50; i--)
//        {
//            Console.WriteLine("Reverse" + i);
//            Thread.Sleep(100);

//        }

//    }
//    static void table()
//    {
//        int n = 9;
//        for(int i = 1; i <= 10; i++)
//        {
//            Console.WriteLine("table" + n * 1);
//            Thread.Sleep(100);

//        }
//    }
//    public static void Main(String[] args)
//    {
//       Thread t1=new Thread(reverse);
//        t1.Start();
//        Thread t2=new Thread(table);
//        t2.Start();
        
//    }
//}

