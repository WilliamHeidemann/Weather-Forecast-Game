using System;
using UtilityToolkit.Runtime;

namespace Model
{
    public class WeatherPrediction
    {
        private readonly Observable<Weather> _prediction;

        public WeatherPrediction()
        {
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
        }
        
        private void ChangeUI(Weather weatherSelection)
        {
            throw new NotImplementedException();
        }
    }
}