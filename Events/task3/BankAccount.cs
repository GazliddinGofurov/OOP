using System.Xml.Serialization;

class BankAccount
{
    public decimal Balance {get; private set;}
    public event EventHandler<MoneyEventArgs>? OnMoneyDeposited;
    public event EventHandler<MoneyEventArgs>? OnMoneyWithdraw;
    public event EventHandler<MoneyEventArgs>? OnLimitExeeded;
    
    
    public void Deposit(decimal amount)
    {
       
            Balance+=amount; 
            OnMoneyDeposited?.Invoke(
                this,
                new MoneyEventArgs(amount));
  
    }
    public void Withdraw(decimal amount)
    {
        if(Balance> amount)
        {
            Balance-= amount;
            OnMoneyWithdraw?.Invoke(
                this,
                new MoneyEventArgs(amount)
            );
        }
        else
        {
            OnLimitExeeded?.Invoke(
                this,
                new MoneyEventArgs(amount)
            );
        }
    }

}