using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class Tenant1Service : IService
    {
        private static readonly string[] Summaries = new[]
        {
            "1_Freezing", "1_Bracing", "1_Chilly", "1_Cool", "1_Mild", "1_Warm", "1_Balmy", "1_Hot", "1_Sweltering", "1_Scorching"
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
