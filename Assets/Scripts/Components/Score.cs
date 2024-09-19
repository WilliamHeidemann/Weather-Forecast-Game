using System;
using Model;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    public PointTracker PointTracker;

    private void Awake()
    {
        PointTracker = new PointTracker(text);
    }
}
