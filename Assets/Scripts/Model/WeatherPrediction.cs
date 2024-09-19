using System;
using UnityEngine;
using UnityEngine.UI;
using UtilityToolkit.Runtime;

namespace Model
{
    public class WeatherPrediction
    {
        private readonly Observable<Weather> _prediction;
        private Color _notSelected;
        private Color _selected;
        private Image _image1;
        private Image _image2;
        private Image _image3;

        public WeatherPrediction(Color notSelected, Color selected, Image image1, Image image2, Image image3)
        {
            _notSelected = notSelected;
            _selected = selected;
            _image1 = image1;
            _image2 = image2;
            _image3 = image3;
            _prediction = new Observable<Weather>(Weather.Sunny);
            _prediction.OnValueChanged += ChangeUI;
        }
        
        public Weather GetPrediction()
        {
            return _prediction.Value;
        }
        
        public void Interact()
        {
            _prediction.Value = _prediction.Value switch
            {
                Weather.Sunny => Weather.Rainy,
                Weather.Rainy => Weather.Snowy,
                Weather.Snowy => Weather.Sunny,
                _ => throw new ArgumentOutOfRangeException()
            };
            StaticValues.PredictedWeather = _prediction.Value;
        }
        
        private void ChangeUI(Weather weatherSelection)
        {
            switch (weatherSelection)
            {
                case Weather.Sunny:
                    _image1.color = _selected;
                    _image2.color = _notSelected;
                    _image3.color = _notSelected;
                    break;
                case Weather.Rainy:
                    _image1.color = _notSelected;
                    _image2.color = _selected;
                    _image3.color = _notSelected;
                    break;
                case Weather.Snowy:
                    _image1.color = _notSelected;
                    _image2.color = _notSelected;
                    _image3.color = _selected;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(weatherSelection), weatherSelection, null);
            }
        }
    }
}