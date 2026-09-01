class Thermostat
{
    private double _currentTemperature;
    public  event EventHandler<TempChangedEventArgs>? TemperatureChanged;
    
    public double CurrentTemperature
    {
        get
        {
            return _currentTemperature;
        }
        set
        {
            double oldTemperature = _currentTemperature;
            _currentTemperature = value;
            TemperatureChanged?.Invoke(
                this,
                new TempChangedEventArgs(oldTemperature,value)
            );
        }
    }
}