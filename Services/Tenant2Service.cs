using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class Tenant2Service : IService
    {
        private static readonly string[] Summaries = new[]
        {
            "2_Freezing", "2_Bracing", "2_Chilly", "2_Cool", "2_Mild", "2_Warm", "2_Balmy", "2_Hot", "2_Sweltering", "2_Scorching"
        };

        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
