////anita and kavita are two thraed performing same taks same time which is find the largest number given by user input. Both threads are running simultaneously and trying to find the largest number from the same set of inputs. They will compare their results and print the largest number found by either of them.

//class largestnum //class name
//{
//    static void user() // method for thread
//    {
//        Console.WriteLine("enter the first number:"); // user input for first number
//        int n = int.Parse(Console.ReadLine());

//        Console.WriteLine("enter the second number:"); // user input for second number
//        int m = int.Parse(Console.ReadLine());

//        if (n < m) // compare the two numbers and print the largest number
//        {
//            Console.WriteLine("largest number is:" + m);
//            Thread.Sleep(1000);
//        }
//        else
//        {
//            Console.WriteLine("largest number is:" + n);
//            Thread.Sleep(1000);
//        }
//    }
//    public static void Main(string[] args)
//    {
//        Thread anita = new Thread(user); // create thread object and pass method name as parameter

//        anita.Name = "first thread"; // set thread name for anita
//        anita.Start();
//        anita.Join(); // Wait for anita to finish before starting kavita

//        Thread kavita = new Thread(user); //
//        kavita.Name = "second thread";
//        kavita.Start(); //            
//    }
//}
//    //void findlargest()
//    //{
//    //    Console.WriteLine("Enter the number:");
//    //    int n = int.Parse(Console.ReadLine());
//    //for(int i = 0; i < n; i++)
//    //    {
//    //        int num = int.Parse(Console.ReadLine());
//    //        if (num > largest)
//    //        {
//    //            largest = num;
//    //        }
//    //    }
    


   

