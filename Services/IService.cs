using System.Collections.Generic;

namespace Services
{
    public interface IService
    {
        IEnumerable<WeatherForecast> Get();
    }
}