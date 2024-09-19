using System;
using Model;
using UnityEngine;

namespace Components
{
    public class ItemSelector : MonoBehaviour
    {
        private WeatherPrediction _weatherPrediction;

        private void Start()
        {
            _weatherPrediction = new WeatherPrediction();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _weatherPrediction.Interact();
            }
        }

        public Weather GetWeatherPrediction() => _weatherPrediction.GetPrediction();
    }
}