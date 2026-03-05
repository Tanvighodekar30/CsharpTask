

class Bank
{
    int balance = 1000;
    object lockObj = new object();

    public void Withdraw()
    {
        lock (lockObj)
        {
            balance = balance - 500;
            Console.WriteLine("Withdraw 500, Balance = " + balance);
        }
    }

    public void Deposit()
    {
        lock (lockObj)
        {
            balance = balance + 300;
            Console.WriteLine("Deposit 300, Balance = " + balance);
        }
    }

    public static void Main(string[] args)
    {
        Bank b = new Bank();

        Thread t1 = new Thread(b.Withdraw);
        Thread t2 = new Thread(b.Deposit);

        t1.Start();
        t2.Start();
    }
}
