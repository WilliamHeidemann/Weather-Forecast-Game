using UnityEngine;

namespace Model.Items
{
    public class SunglassesStats : ItemStats
    {
        public SunglassesStats(WeatherForecast forecast)
        {
            SunPoints = Mathf.Min((int)(1f / forecast.ChanceOfSun * CorrectChoiceBoost), 3000);
            RainPoints = Mathf.Min((int)(1f / forecast.ChanceOfRain * InCorrectChoiceBoost1), 3000);
            SnowPoints = Mathf.Min((int)(1f / forecast.ChanceOfSnow * InCorrectChoiceBoost2), 3000);
        }
    }
}