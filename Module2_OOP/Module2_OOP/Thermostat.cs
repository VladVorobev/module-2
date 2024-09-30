using System;

public class Thermostat
{
    public Thermostat(TemperatureSensor sensor)
    {
        sensor.TemperatureChanged += () => OnTemperatureChanged(sensor.Temperature);
    }

    private void OnTemperatureChanged(int temperature)
    {
        if (temperature < 20)
            Console.WriteLine("Включаем отопление.");
        else
            Console.WriteLine("Выключаем отопление.");
    }
}
