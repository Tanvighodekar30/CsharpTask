// class employeee
//    {
//    int empid;
//    long empsalary;

//    employeee(int empid, long empsalary)
//    {
//        this.empid = empid;
//        this.empsalary = empsalary;
//        //Console.WriteLine(empid);
//        //Console.WriteLine(empsalary);

//    }
//    employeee(employeee e) //copy constructor
//    {
//        this.empid = e.empid; //304
//        this.empsalary = e.empsalary; //100000
//        //Console.WriteLine(empid);
//        //Console.WriteLine(empsalary);
//    }
//     public static void Main(string[] args)
//    {
//        //employeee e1 = new employeee(304, 100000);
//        //employeee e2 = new employeee(e1);
//        employeee e1 = new employeee(304, 100000); //object creation 1
//        Console.WriteLine(e1.empid);
//        Console.WriteLine(e1.empsalary);
//         employeee e2 = new employeee(e1); //object creation 2 using copy constructor
//        Console.WriteLine(e2.empid);
//        Console.WriteLine(e2.empsalary);
//    }
//}

