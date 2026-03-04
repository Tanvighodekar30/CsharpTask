 

//class LoginForm
//{
//    static void Main()
//    {
//        string path = "C:\\Users\\Tanvi\\source\\repos\\ConsoleApp1\\registration.txt";

//        Console.WriteLine("----- LOGIN FORM -----");

//        Console.Write("Enter ID: ");
//        string loginId = Console.ReadLine();

//        Console.Write("Enter Email: ");
//        string loginEmail = Console.ReadLine();

//        bool found = false;

//        if (File.Exists(path))
//        {
//            StreamReader sr = new StreamReader(path);
//            string line;

//            while ((line = sr.ReadLine()) != null)
//            {
//                string[] data = line.Split(',');

//                string storedId = data[0];
//                string storedEmail = data[4];

//                if (storedId == loginId && storedEmail == loginEmail)
//                {
//                    found = true;
//                    break;
//                }
//            }

//            sr.Close();

//            if (found)
//            {
//                Console.WriteLine("\nLogin Successfully");
//            }
//            else
//            {
//                Console.WriteLine("\nInvalid ID or Email ❌");
//            }
//        }
//        else
//        {
//            Console.WriteLine("No registration records found.");
//        }
//    }
//}