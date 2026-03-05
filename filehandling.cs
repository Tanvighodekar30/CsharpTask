//using System.Threading.Channels;

//class filehandling
//    {
//    public static void Main(String[] args)
//    {
//        filehandling f = new filehandling();
        
//        f.fileinfoclass();
//        f.filestaticclass();

//    }
//    void fileinfoclass()
//    {
//        string file_destination = "C:\\Users\\Tanvi\\source\\repos\\ConsoleApp1\\2ndmarch.txt";
//        FileInfo f1= new FileInfo(file_destination);
//        f1.Create().Close();
//        //if file is exist then display message

//        if (f1.Exists)
//        {
//            f1.Delete();
//            if (f1.Exists)
//            {
//                Console.WriteLine("file is not deleted");
//            }
//            else
//            {
//                Console.WriteLine("file deleted successfully");
//            }
//        }
//        else
//        {
//            Console.WriteLine("file is not exist");
//        }
//        Console.WriteLine("Name of file is :" + f1.Name);
//        Console.WriteLine("Full Name of file is :" + f1.Name);
//        Console.WriteLine("creation time of file is : " + f1.CreationTime);
//        Console.WriteLine("Directory of file is : " + f1.DirectoryName);
//    }
//    void filestaticclass()
//    {
//        Console.WriteLine("file static class");
//        string file_Path = "C:\\Users\\Tanvi\\source\\repos\\ConsoleApp1\\hoil.txt";
//        File.Create(file_Path);
//        //if file is exist then display message
//        if(File.Exists(file_Path))
//        {
//            Console.WriteLine("file is exist");
//        }
//        else
//        {
//            Console.WriteLine("file is not exist");
//        }
//        Console.WriteLine("creation time of file is " + File.GetCreationTime(file_Path));
//    }
//}

