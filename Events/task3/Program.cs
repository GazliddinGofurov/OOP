using System;
namespace _task3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account =  new BankAccount();
            SMSNotificationService sms =  new SMSNotificationService();
            EmailLoggerService email =  new EmailLoggerService();

            sms.Subscribe(account);
            email.Subscribe(account);

            account.Deposit(1000);
            account.Withdraw(300);
            account.Withdraw(1000);



        }
    }
}