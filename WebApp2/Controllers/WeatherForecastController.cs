using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;        
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;            
        }

        [HttpGet]
        public IEnumerable<WeatherForecastDTO> Get()
        {
            return _weatherForecastService.GetItems();
        }
    }
}
