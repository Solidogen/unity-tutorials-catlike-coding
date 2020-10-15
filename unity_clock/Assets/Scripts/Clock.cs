using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = 30;
    const float minutesToDegrees = 6;
    const float secondsToDegrees = 6;

    [SerializeField]
    Transform hoursPivot = default;

    [SerializeField]
    Transform minutesPivot = default;

    [SerializeField]
    Transform secondsPivot = default;

    void Awake()
    {
    }

    void Start()
    {
    }

    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }
}
