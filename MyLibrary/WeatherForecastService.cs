using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLibrary
{
    public class WeatherForecastService: IWeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IMapper _mapper;

        public WeatherForecastService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IEnumerable<WeatherForecastDTO> GetItems()
        {
            var rng = new Random();

            var items = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToList();

            return items.Select(item => _mapper.Map<WeatherForecastDTO>(item)).ToList();
        }
    }
}
