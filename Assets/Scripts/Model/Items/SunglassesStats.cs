namespace Model.Items
{
    public class SunglassesStats : ItemStats
    {
        public SunglassesStats(WeatherForecast forecast)
        {
            SunPoints = (int)(1f / forecast.ChanceOfSun * CorrectChoiceBoost);
            RainPoints = (int)(1f / forecast.ChanceOfRain * InCorrectChoiceBoost1);
            SnowPoints = (int)(1f / forecast.ChanceOfSnow * InCorrectChoiceBoost2);
        }
    }
}