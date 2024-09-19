using System.Collections.Generic;
using Model.Items;
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
            StaticValues.ActualWeather = GetWeather();
        }

        public float ChanceOfSun { get; }
        public float ChanceOfRain { get; }
        public float ChanceOfSnow { get; }

        private Weather GetWeather()
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

        public Dictionary<Weather, ItemStats> GetDictionary()
        {
            return new Dictionary<Weather, ItemStats>()
            {
                { Weather.Rainy, new UmbrellaStats(this) },
                { Weather.Snowy, new SkiStats(this) },
                { Weather.Sunny, new SunglassesStats(this) }
            };
        }
    }
}