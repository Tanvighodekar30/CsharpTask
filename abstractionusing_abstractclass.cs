
//abstract class school  //parent class
//{
//    abstract public void total_countof_student();
//    abstract public void teacher();
//}

//class schooldata : school //child class
//{
//    public override void total_countof_student()
//    {
//        Console.WriteLine("Total count of student is 1000");
//    }
//    public override void teacher()
//    {
//        Console.WriteLine("There is multiple work of teacher");
//    }
//}




//class abstractionusing_abstractclass
//{
//    public static void Main(string[] args)
//    {
//        schooldata o = new schooldata();
//        o.total_countof_student();
//        o.teacher();
//    }
//}
      


 //abstract class Notification //parent class
 //{
 //   // Abstract method (must be implemented differently)
//    public abstract void Send(string message);

//    // Common method
//    public abstract void msg();
//    public abstract void call();
   

//}

//class EmailNotification : Notification  //child class
//{
//    public override void Send(string message)
//    {
//        Console.WriteLine("Email sent: " + message);
//    }
//    public override void msg()
//    {
//        Console.WriteLine("This is a common method for all notifications.");
//    }
//}

//class SmsNotification : Notification
//{
//    public override void Send(string message)
//    {
//        Console.WriteLine("SMS sent: " + message);
//    }
//}

//class abstractionusing_abstractclass
//{
//    static void Main()
//    {
//        Notification notification = new EmailNotification();

//        notification.Send("Your order has been shipped.");
//        notification.LogNotification();
//    }
//}
 