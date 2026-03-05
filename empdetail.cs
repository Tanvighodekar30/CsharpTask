
//////empid,emp dis, emp saraly,yr of experiance take input from user and store in binary file and read the data from file and display on console

//class empdetail
//{
//    void empdeatils()
//    {
//        string path = "C:\\Users\\Tanvi\\source\\repos\\ConsoleApp1\\empdetail.bin";
//        Console.WriteLine("emp details");
//        Console.WriteLine("enter the emp id");
//        int empid = int.Parse(Console.ReadLine());

//        Console.WriteLine("emp disignation");
//        string empdis = (Console.ReadLine());
            
//        Console.WriteLine("emp saraly");
//        int empsaraly = int.Parse(Console.ReadLine());
//        Console.WriteLine("yr of experiance");
//        double yr = int.Parse(Console.ReadLine());


//        FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
//       BinaryWriter sw = new BinaryWriter(fs);
//        sw.Write("emp id: " + empid);
//        sw.Write("emp disignation: " + empdis);
//        sw.Write("emp saraly: " + empsaraly);
//        sw.Write("yr of experiance: " + yr);
//        sw.Close();
//        fs.Close();
//    }
//    void empdetailread()
//    {
//        string path = "C:\\Users\\Tanvi\\source\\repos\\ConsoleApp1\\empdetail.bin";
//        FileStream fs2 = new FileStream(path, FileMode.Open);
//        BinaryReader sr = new BinaryReader(fs2);
//        int id = sr.ReadInt32();
//        string dis = sr.ReadString();
//        int saraly = sr.ReadInt32();
//        double yr = sr.ReadDouble();
        
//        sr.Close();
//        fs2.Close();
//    }
//    public static void Main(String[] args)
//    {
//        empdetail ed = new empdetail();
//        ed.empdeatils();
//        ed.empdetailread();
//    }
//}

