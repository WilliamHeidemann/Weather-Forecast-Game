using UnityEngine;
using Model;

public class WeatherChange : MonoBehaviour
{

    public GameObject Sunny;
    public GameObject Rainy;
    public GameObject Snowy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sunny.SetActive(false);
        Rainy.SetActive(false);
        Snowy.SetActive(false);

        switch (StaticValues.ActualWeather)
        {
            case Weather.Sunny:
                Sunny.SetActive(true);
                break;
            case Weather.Rainy:
                Rainy.SetActive(true);
                break;
            case Weather.Snowy:
                Snowy.SetActive(true);
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
