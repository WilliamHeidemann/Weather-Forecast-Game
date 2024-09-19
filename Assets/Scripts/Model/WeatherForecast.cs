using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace Model
{
    public class WeatherForecast
    {
        public WeatherForecast()
        {
            ChanceOfSun = Random.value;
            ChanceOfRain = Random.Range(0f, 1f - ChanceOfSun);
            ChanceOfSnow = 1f - (ChanceOfSun + ChanceOfRain);
        }

        public float ChanceOfSun { get; }
        public float ChanceOfRain { get; }
        public float ChanceOfSnow { get; }

        public Weather GetWeather()
        {
            var value = Random.value;

            if (value < ChanceOfSun)
                return Weather.Sunny;

            if (value < ChanceOfSun + ChanceOfRain)
                return Weather.Rainy;

            return Weather.Snowy;
        }

        public override string ToString()
        {
            return
                $"Sun: {ChanceOfSun}. Rain: {ChanceOfRain}. Snow: {ChanceOfSnow}. Sum: {ChanceOfSun + ChanceOfRain + ChanceOfSnow}";
        }

        public Dictionary<Weather, float> GetDictionary()
        {
            return new Dictionary<Weather, float>()
            {
                { Weather.Rainy, ChanceOfRain },
                { Weather.Snowy, ChanceOfSnow },
                { Weather.Sunny, ChanceOfSun }
            };
        }
    }
}