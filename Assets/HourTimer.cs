using UnityEngine;
using System;

public class HourTimer : MonoBehaviour
{
    public int currentHour = 0;
    public Action<int> OnHourChanged;

    private float timer = 0f;
    private const float hourDuration = 3f; // 3 seconds per hour

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= hourDuration)
        {
            timer = 0f;
            currentHour = (currentHour + 1) % 24;
            OnHourChanged?.Invoke(currentHour);
        }
    }
}