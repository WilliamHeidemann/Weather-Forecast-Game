using System;
using Model;
using TMPro;
using UnityEngine;
using UnityUtils;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    public PointTracker PointTracker;
    private void Awake()
    {
        text.SetText("Points: " + StaticValues.Points.ToString());
        PointTracker = new PointTracker(text);
    }
}
