//using System.Xml;

//interface client1
//{
//    void apicall();
//}

//interface client2
//{
//    void payment();
//}
//interface client3
//{
//    void UI();
//}
//class developer : client1, client2, client3
//{
//    public void apicall()
//    {
//        Console.WriteLine("client1:fetch all the details of users");

//    }
//    public void payment()
//    {
//        Console.WriteLine("client2: display all the payment methods");
//    }
//    public void UI()
//    {
//        Console.WriteLine("client3:UI should be look attractive ");
//    }
//}



//class abstractionusing_interface
//{
//    public static void Main(string[] args)
//    {
//        developer o = new developer();
//        o.apicall();
//        o.payment();
//        o.UI();
//    }
//}


//interface Camera //parent interface
//{
//    void TakePhoto();
//}

//interface MusicPlayer
//{
//    void PlayMusic();
//}

//class SmartPhone : Camera, MusicPlayer //child class implementing both interfaces
//{
//    public void TakePhoto()
//    {
//        Console.WriteLine("Photo captured");
//    }

//    public void PlayMusic()
//    {
//        Console.WriteLine("Playing music");
//    }
//}

//class abstractionusing_interface
//{
//    static void Main()
//    {
//        SmartPhone phone = new SmartPhone();
//        phone.TakePhoto();
//        phone.PlayMusic();
//    }
//}