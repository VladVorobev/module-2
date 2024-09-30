using System;

public class TemperatureSensor
{
    public event Action TemperatureChanged;
    private int temperature;

    public int Temperature
    {
        get => temperature;
        set
        {
            if (temperature != value)
            {
                temperature = value;
                TemperatureChanged?.Invoke();
            }
        }
    }
}
