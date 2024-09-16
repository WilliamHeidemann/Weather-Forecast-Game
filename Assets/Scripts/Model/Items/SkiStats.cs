namespace Model.Items
{
    public class SkiStats : ItemStats
    {
        public SkiStats(WeatherForecast forecast)
        {
            SunPoints = (int)(1f / forecast.ChanceOfSun * InCorrectChoiceBoost1);
            RainPoints = (int)(1f / forecast.ChanceOfRain * InCorrectChoiceBoost2);
            SnowPoints = (int)(1f / forecast.ChanceOfSnow * CorrectChoiceBoost);
        }
    }
}