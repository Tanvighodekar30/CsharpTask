//using System;
//using System.IO;

//class RegistrationForm
//{
//    public static void Main(string[] args)
//    {
//        string path = "C:\\Users\\Tanvi\\source\\repos\\ConsoleApp1\\registration.txt";

//        Console.WriteLine("----- REGISTRATION FORM -----");

//        Console.Write("Enter ID: ");
//        string id = Console.ReadLine();

//        Console.Write("Enter Name: ");
//        string name = Console.ReadLine();

//        Console.Write("Enter Age: ");
//        string age = Console.ReadLine();

//        Console.Write("Enter Gender: ");
//        string gender = Console.ReadLine();

//        Console.Write("Enter Email: ");
//        string email = Console.ReadLine();

//        Console.Write("Enter Phone: ");
//        string phone = Console.ReadLine();

//        Console.Write("Enter Address: ");
//        string address = Console.ReadLine();

//        Console.Write("Enter City: ");
//        string city = Console.ReadLine();

//        Console.Write("Enter Course: ");
//        string course = Console.ReadLine();

//        Console.Write("Enter Fees: ");
//        string fees = Console.ReadLine();

//        // Writing data to file
//        StreamWriter sw = new StreamWriter(path, true);
//        sw.WriteLine(id + "," + name + "," + age + "," + gender + "," +
//                     email + "," + phone + "," + address + "," +
//                     city + "," + course + "," + fees);
//        sw.Close();

//        Console.WriteLine("\nRegistration Saved Successfully!\n");

//        // Reading Data
//        Console.WriteLine("----- STORED RECORDS -----");

//        StreamReader sr = new StreamReader(path);
//        string line;

//        while ((line = sr.ReadLine()) != null)
//        {
//            string[] data = line.Split(',');

//            Console.WriteLine("ID      : " + data[0]);
//            Console.WriteLine("Name    : " + data[1]);
//            Console.WriteLine("Age     : " + data[2]);
//            Console.WriteLine("Gender  : " + data[3]);
//            Console.WriteLine("Email   : " + data[4]);
//            Console.WriteLine("Phone   : " + data[5]);
//            Console.WriteLine("Address : " + data[6]);
//            Console.WriteLine("City    : " + data[7]);
//            Console.WriteLine("Course  : " + data[8]);
//            Console.WriteLine("Fees    : " + data[9]);
//            Console.WriteLine("---------------------------");
//        }

//        sr.Close();
//    }
//}