// class clac
//{
//    //instance variable
//    public int n1; //10
//    public int n2; //5
//    public void div(int n1, int n2) //local variable/parameter 
//    { 
//        this.n1 = n1; //10
//        this.n2 = n2; //5
//    }
//}

//class thiskeyword
//    {
//    public static void Main(String[] args)
//    {
//        clac o = new clac();
//        o.div(10, 5);
//        Console.WriteLine("The value of n1 is: " + o.n1);
//        Console.WriteLine("The value of n2 is: " + o.n2);
//        Console.WriteLine("division is: "  + o.n1 / o.n2);
//    }
//    }




/// THIS KEYWORD IN METHOD

//class thiskeyword
//{
//    public void Show()
//    {
//        Console.WriteLine("Hello tanvi");
//    }

//    public void display()
//    {
//        this.Show(); // Calling another method
//        Console.WriteLine("This is the display");
//    }
//    public static void Main(string[] args)
//    {
//        thiskeyword obj = new thiskeyword();
//        obj.display();
//    }

//}




//class Employee
//{
//    string name;
//    int salary;

//    // Constructor 1 (Single parameter)
//    public Employee(string name) : this(name, 0)
//    {
//    }

//    // Constructor 2 (Two parameters)
//    public Employee(string name, int salary)
//    {
//        this.name = name;
//        this.salary = salary;
//    }

//    // Method to display employee details
//    public void Display()
//    {
//        Console.WriteLine("Employee Name: " + name);
//        Console.WriteLine("Salary: " + salary);
//        Console.WriteLine();
//    }
//}

//class thiskeyword
//{
//    static void Main(string[] args)
//    {
//        // Calling constructor with one parameter
//        Employee emp1 = new Employee("Tanvi");

//        // Calling constructor with two parameters
//        Employee emp2 = new Employee("Amit", 50000);

//        emp1.Display();
//        emp2.Display();

//        Console.ReadLine();
//    }
//}
