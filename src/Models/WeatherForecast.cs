namespace Models;

public record WeatherForecast(DateTime Date, int TemperatureC, string? Summary, int? WindSpeed)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}