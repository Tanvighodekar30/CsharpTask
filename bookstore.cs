

//class bookstore
//{
//public static void Main(string[] args)
//    {
//        string path = "books.txt";

//        Console.WriteLine("----- BOOK STORE -----");
//        Console.Write("Enter Book Name: ");
//        string name = Console.ReadLine();

//        Console.Write("Enter Quantity: ");
//        int quantity = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter Price: ");
//        double price = Convert.ToDouble(Console.ReadLine());

//        // Writing data to file
//        StreamWriter sw = new StreamWriter(path, true); // true = append mode
//        sw.WriteLine(name );
//        sw.WriteLine(quantity);
//        sw.WriteLine(price);
//        sw.Close();

//        Console.WriteLine("\nBook data saved successfully!\n");

//        // Reading data from file
//        Console.WriteLine("----- STORED BOOKS -----");
//        StreamReader sr = new StreamReader(path);

//        string line;
//        while ((line = sr.ReadLine()) != null)
//        {
//            string[] data = line.Split(',');

//            Console.WriteLine("Book Name: " + data[0]);
//            Console.WriteLine("Quantity : " + data[1]);
//            Console.WriteLine("Price    : " + data[2]);
//            Console.WriteLine("-----------------------");
//        }

//        sr.Close();
//    }
//}