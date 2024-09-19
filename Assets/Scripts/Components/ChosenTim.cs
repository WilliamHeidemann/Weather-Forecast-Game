using UnityEngine;
using Model;

public class ChosenTim : MonoBehaviour
{

    public GameObject timSunglasses;
    public GameObject timUmbrella;
    public GameObject timSkies;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timSunglasses.SetActive(false);
        timUmbrella.SetActive(false);
        timSkies.SetActive(false);

        switch (StaticValues.PredictedWeather)
        {
            case Weather.Sunny:
                timSunglasses.SetActive(true);
                break;
            case Weather.Rainy:
                timUmbrella.SetActive(true);
                break;
            case Weather.Snowy:
                timSkies.SetActive(true);
                break;
        }
        
    }
}
