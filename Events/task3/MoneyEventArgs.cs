class MoneyEventArgs : EventArgs
{
    public decimal Amount {get;}
    public MoneyEventArgs (decimal amount)
    {
        Amount = amount;
    }
}