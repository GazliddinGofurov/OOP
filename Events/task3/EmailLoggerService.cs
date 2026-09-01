class EmailLoggerService
{
   public void Subscribe(BankAccount account)
    {
        account.OnMoneyDeposited+=MoneyDeposidHandler;
        account.OnMoneyWithdraw+= MoneyWithdrawHandler;
        account.OnLimitExeeded+=LimitExceededHandler;
    }

    private void MoneyDeposidHandler(object? sender, MoneyEventArgs e)
    {
        Console.WriteLine($"EMAIL LOG: Deposited {e.Amount}");
    }
    private void MoneyWithdrawHandler(object? sender, MoneyEventArgs e)
    {
        Console.WriteLine($"EMAIL LOG: Withdrawn {e.Amount}");
    }
    private void LimitExceededHandler(object? sender, MoneyEventArgs e)
    {
        Console.WriteLine($"EMAIL LOG: Limit exeeded. Requested: {e.Amount}");
    }
}