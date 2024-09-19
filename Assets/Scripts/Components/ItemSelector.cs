using System;
using Model;
using UnityEngine;
using UnityEngine.Rendering;

namespace Components
{
    public class ItemSelector : MonoBehaviour
    {
        private Observable<Weather> _prediction;

        private void Start()
        {
            _prediction = new Observable<Weather>();
            _prediction.onValueChanged += ChangeUI();
        }

        private Action<Weather> ChangeUI()
        {
            throw new NotImplementedException();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Interact();
            }
        }

        public void Interact()
        {
            _prediction.value = _prediction.value switch
            {
                Weather.Sunny => Weather.Rainy,
                Weather.Rainy => Weather.Snowy,
                Weather.Snowy => Weather.Sunny,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public Weather GetPrediction()
        {
            return _prediction.value;
        }
    }
}