using AutoMapper;

namespace MyLibrary
{
    public class GeneralProfile: Profile
    {
        public GeneralProfile()
        {
            CreateMap<WeatherForecast, WeatherForecastDTO>();
        }
    }
}
