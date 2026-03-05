//class binaryfile_handling
//{
//    void write_data()
//    {
//        string path = "C:\\Users\\Tanvi\\source\\repos\\ConsoleApp1\\binarydata.bin";
//        FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
//        BinaryWriter bw = new BinaryWriter(fs);
//        bw.Write(500);
//        bw.Write("Hello World");
//        bw.Write(3.14);
//        bw.Write(true);
//        bw.Close();
//        fs.Close();

//    }
//    void read_data()
//    {
//        string path = "C:\\Users\\Tanvi\\source\\repos\\ConsoleApp1\\binarydata.bin";
//        FileStream fs2 =new FileStream(path, FileMode.Open);
//        BinaryReader br=new BinaryReader(fs2);
//        int num=br.ReadInt32();
//        string str=br.ReadString(); 
//        double pi=br.ReadDouble();
//        bool b=br.ReadBoolean();

//        Console.WriteLine("Integer: " + num);
//        Console.WriteLine("String: " + str);
//        Console.WriteLine("Double: " + pi);
//        Console.WriteLine("Boolean: " + b);
//        br.Close();
//        fs2.Close();
//    }
//    public static void Main(String[] args)
//    {
//        binaryfile_handling bh = new binaryfile_handling();
//        bh.write_data();
//        bh.read_data();
//    }
//}

