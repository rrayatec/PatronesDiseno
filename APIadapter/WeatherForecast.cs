namespace APIadapter;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

    public static implicit operator WeatherForecast(string v)
    {
        throw new NotImplementedException();
    }

    public static implicit operator WeatherForecast?(List<WeatherForecast>? v)
    {
        throw new NotImplementedException();
    }
}
