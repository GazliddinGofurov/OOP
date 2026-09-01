class SMSNotificationService
{
    public void Subscribe(BankAccount account)
    {
        account.OnMoneyDeposited+=MoneyDeposidHandler;
        account.OnMoneyWithdraw+=MoneyWithdrawHandler;
        account.OnLimitExeeded+= LimitExceededHandler;
    }

    private void MoneyDeposidHandler(object? sender, MoneyEventArgs e)
    {
        Console.WriteLine($"SMS: Hisobingizga {e.Amount} pul qo'shildi");
    }
    private void MoneyWithdrawHandler(object? sender, MoneyEventArgs e)
    {
        Console.WriteLine($"SMS: Hisobingizdan {e.Amount} pul yechildi");
    }
    private void LimitExceededHandler(object? sender, MoneyEventArgs e)
    {
        Console.WriteLine($"SMS: Hisobingizda {e.Amount} mablag' yoq");
    }


}