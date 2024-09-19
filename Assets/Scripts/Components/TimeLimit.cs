using Model;
using Model.Items;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UtilityToolkit.Runtime;

namespace Components
{
    public class TimeLimit : MonoBehaviour
    {
        [SerializeField] private Slider slider;

        private bool _isCounting;
        private CountdownTimer _timer;
        private const float SecondsToFinish = 5f;
        public BarChartScript barChartScript;
        private ItemStats _stats;

        private void Start()
        {
            slider.minValue = 0f;
            slider.maxValue = SecondsToFinish;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!_isCounting)
                {
                    _timer = new CountdownTimer(SecondsToFinish);
                    _isCounting = true;
                }
                
                _timer.Reset();
            }

            if (!_isCounting) return;
            
            slider.value = _timer.SecondsLeft;

            if (_timer.IsFinished)
            {
                OnTimerExpire();
                _isCounting = false;
            }
        }

        private void OnTimerExpire()
        {
            barChartScript.forecast.GetDictionary().TryGetValue(StaticValues.ActualWeather, out _stats);
            switch (StaticValues.PredictedWeather)
            {
                case Weather.Sunny:
                    barChartScript.score.PointTracker.AddPoints(_stats.SunPoints);
                    break;
                case Weather.Rainy:
                    barChartScript.score.PointTracker.AddPoints(_stats.RainPoints);
                    break;
                case Weather.Snowy:
                    barChartScript.score.PointTracker.AddPoints(_stats.SnowPoints);
                    break;
                default:
                    break;
            }
            barChartScript.score.PointTracker.UpdatePoints();
            SceneManager.LoadScene("timmyWalking");
        }
    }
}