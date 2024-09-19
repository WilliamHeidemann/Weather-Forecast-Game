using UnityEngine;

namespace Model.Items
{
    public class UmbrellaStats : ItemStats
    {
        public UmbrellaStats(WeatherForecast forecast)
        {
            SunPoints = Mathf.Min((int)(1f / forecast.ChanceOfSun * InCorrectChoiceBoost2), 3000);
            RainPoints = Mathf.Min((int)(1f / forecast.ChanceOfRain * CorrectChoiceBoost), 3000);
            SnowPoints = Mathf.Min((int)(1f / forecast.ChanceOfSnow * InCorrectChoiceBoost1), 3000);
        }
    }
}