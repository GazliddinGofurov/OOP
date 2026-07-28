using System;
namespace _task3
{
struct BankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public BankAccount(string accountNumber, decimal balance)
    {
       AccountNumber =  accountNumber;
       Balance =  balance; 
    }

    public void Deposit (decimal amount)
    {
        Balance +=amount;
    }

    public void Withdraw(decimal amount)
    {
        if(amount<= Balance)
        {
            Balance -= amount;
        }
        else
        {
            System.Console.WriteLine(" buncha pulingiz yoq");
        }
    }

    public void Display()
        {
            System.Console.WriteLine($"Account{AccountNumber} Balance {Balance}");
        }
}
    class Program
    {
        static void Main (string[] args)
        {
            BankAccount acc1 =  new BankAccount("001",100);
            BankAccount acc2 = acc1;

            acc2.Deposit(50);

            acc1.Display();
            acc2.Display();
        }
    }
}