using Model;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class BarChartScript : MonoBehaviour
{
    public WispBarChart sunChart;
    public WispBarChart rainChart;
    public WispBarChart snowChart;
    public TMP_Text sunChance;
    public TMP_Text rainChance;
    public TMP_Text snowChance;
    public WeatherForecast forecast;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        forecast = new WeatherForecast();
        GenerateValues();
        AddGridValues();
    }

    void GenerateValues()
    {
        var dict = forecast.GetDictionary();
        Dictionary<string, float> sunValues = new Dictionary<string, float>();
        Dictionary<string, float> rainValues = new Dictionary<string, float>();
        Dictionary<string, float> snowValues = new Dictionary<string, float>();
        print(forecast.ChanceOfSun);
        print(forecast.ChanceOfRain);
        print(forecast.ChanceOfSnow);
        foreach (var item in dict)
        {
            print(item.Key);
            print(item.Value);
            if (item.Key is Weather.Snowy)
            {
                snowValues.Add("SunPoints", item.Value.SunPoints);
                snowValues.Add("RainPoints", item.Value.RainPoints);
                snowValues.Add("SnowPoints", item.Value.SnowPoints);
            }
            if (item.Key is Weather.Rainy)
            {
                rainValues.Add("SunPoints", item.Value.SunPoints);
                rainValues.Add("RainPoints", item.Value.RainPoints);
                rainValues.Add("SnowPoints", item.Value.SnowPoints);
            }
            if (item.Key is Weather.Sunny)
            {
                sunValues.Add("SunPoints", item.Value.SunPoints);
                sunValues.Add("RainPoints", item.Value.RainPoints);
                sunValues.Add("SnowPoints", item.Value.SnowPoints);
            }
        }

        sunChart.DrawChart(sunValues, 0, 0, 0, "Points for sunglasses");
        rainChart.DrawChart(rainValues, 0, 0, 0, "Points for umbrella");
        snowChart.DrawChart(snowValues, 0, 0, 0, "Points for skis");
    }

    void AddGridValues()
    {
        int a = (int)(Math.Round(forecast.ChanceOfSun * 100));
        int b = (int)(Math.Round(forecast.ChanceOfRain * 100));
        int c = 100-a-b;
        sunChance.SetText(a.ToString() + "%");
        rainChance.SetText(b.ToString() + "%");
        snowChance.SetText(c.ToString() + "%");
    }
}
