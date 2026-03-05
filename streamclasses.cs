// class streamclasses
//    {
//    public static void Main(String[] args) { 
    
//    streamclasses sh=new streamclasses();
//        sh.writeop();
//        sh.readop();
//    }  
//    void writeop()
//    {
//        string path= "C:\\Users\\Tanvi\\source\\repos\\ConsoleApp1\\hellomarch.txt";
//        //FileStream fs=new FileStream(path, FileMode.Create);
//       // FileStream fs1 = new FileStream(path, FileMode.Open);
//        FileStream fs2= new FileStream(path, FileMode.OpenOrCreate);

//        StreamWriter swr = new StreamWriter(fs2);
//        swr.WriteLine("Happy Hoil");
//        swr.WriteLine("twomorrw is holiday");
//        swr.Close();
//        fs2.Close();
//        Console.WriteLine("data written successfully");
//    }
//    void readop()
//    {
//        string path = "C:\\Users\\Tanvi\\source\\repos\\ConsoleApp1\\hellome.txt";
//        FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
//        StreamReader srd = new StreamReader(fs);
//        string alltext = srd.ReadToEnd();
//        Console.WriteLine(alltext);
//        srd.Close();
//        fs.Close();
//    }
//}
