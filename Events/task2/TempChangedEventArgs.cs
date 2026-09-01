class TempChangedEventArgs: EventArgs
{
    public double OldTemperature { get; }
    public double NewTemperature { get; }

    public TempChangedEventArgs(double oldTemperature, double newTemperature)
    {
        OldTemperature = oldTemperature;
        NewTemperature =  newTemperature;
    }
}