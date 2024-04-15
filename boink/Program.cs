namespace boink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount();
            bankAccount1.Deposit(int.Parse(Console.ReadLine()));
            bankAccount2.Deposit(int.Parse(Console.ReadLine()));
            Console.WriteLine("Account1: " + bankAccount1.GetBalance());
            Console.WriteLine("Account2: " + bankAccount2.GetBalance());
            bankAccount1.Withdraw(int.Parse(Console.ReadLine()));
            bankAccount2.Deposit(int.Parse(Console.ReadLine()));
            Console.WriteLine("Account1: " + bankAccount1.GetBalance());
            Console.WriteLine("Account2: " + bankAccount2.GetBalance());
            bankAccount1.Withdraw(int.Parse(Console.ReadLine()));
            Console.WriteLine("Account1: " + bankAccount1.GetBalance());

        }
    }
}