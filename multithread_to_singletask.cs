//class multithread_to_singletask
//{

//    static void TablePart1()
//    {
//        int n = 5;
//        for (int i = 1; i <= 5; i++)
//            Console.WriteLine("T1: " + n * i);
//    }

//    static void TablePart2()
//    {
//        int n = 5;
//        for (int i = 6; i <= 10; i++)
//            Console.WriteLine("T2: " + n * i);
//    }

//    public static void Main(string[] args)
//    {
//        Thread t1 = new Thread(TablePart1);
//        Thread t2 = new Thread(TablePart2);

//        t1.Start();
//        t2.Start();
//    }
//}


   
