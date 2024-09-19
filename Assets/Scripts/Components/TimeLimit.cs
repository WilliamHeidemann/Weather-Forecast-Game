using System;
using UnityEngine;
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

        private void Start()
        {
            slider.minValue = 0f;
            slider.maxValue = SecondsToFinish;
        }

        private void Update()
        {
            print(slider.value);
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
        }
    }
}