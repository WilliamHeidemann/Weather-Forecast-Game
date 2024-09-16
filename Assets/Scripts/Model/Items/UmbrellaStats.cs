namespace Model.Items
{
    public class UmbrellaStats : ItemStats
    {
        public UmbrellaStats(WeatherForecast forecast)
        {
            SunPoints = (int)(1f / forecast.ChanceOfSun * InCorrectChoiceBoost2);
            RainPoints = (int)(1f / forecast.ChanceOfRain * CorrectChoiceBoost);
            SnowPoints = (int)(1f / forecast.ChanceOfSnow * InCorrectChoiceBoost1);
        }
    }
}