using System.Collections.Generic;
using Model;
using Model.Items;
using UnityEngine;
using UtilityToolkit.Editor;

public class TestComponent : MonoBehaviour
{
    [Button]
    public void MakeForecast()
    {
        var forecast = new WeatherForecast();
        print(forecast);
        print($"Sunglasses stats: {new SunglassesStats(forecast)}");
        print($"Umbrella stats: {new UmbrellaStats(forecast)}");
        print($"Ski stats: {new SkiStats(forecast)}");
    }

    public void WorkWithChart()
    {
        var forecast = new WeatherForecast();
        forecast.GetDictionary();
        var a = forecast.ChanceOfSun;
        var b = forecast.ChanceOfSnow;
    }
}