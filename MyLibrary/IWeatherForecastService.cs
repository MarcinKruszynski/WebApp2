using System.Collections.Generic;

namespace MyLibrary
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecastDTO> GetItems();
    }
}
