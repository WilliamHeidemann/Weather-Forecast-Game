using UnityEngine;

namespace Model.Items
{
    public class SkiStats : ItemStats
    {
        public SkiStats(WeatherForecast forecast)
        {
            SunPoints = Mathf.Min((int)(1f / forecast.ChanceOfSun * InCorrectChoiceBoost1), 3000);
            RainPoints = Mathf.Min((int)(1f / forecast.ChanceOfRain * InCorrectChoiceBoost2), 3000);
            SnowPoints = Mathf.Min((int)(1f / forecast.ChanceOfSnow * CorrectChoiceBoost), 3000);
        }
    }
}