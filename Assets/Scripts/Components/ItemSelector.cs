using System;
using Model;
using UnityEngine;
using UnityEngine.UI;

namespace Components
{
    public class ItemSelector : MonoBehaviour
    {
        private WeatherPrediction _weatherPrediction;
        [SerializeField] private Color notSelected;
        [SerializeField] private Color selected;
        [SerializeField] private Image image1;
        [SerializeField] private Image image2;
        [SerializeField] private Image image3;

        private void Start()
        {
            _weatherPrediction = new WeatherPrediction(notSelected, selected, image1, image2, image3);
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