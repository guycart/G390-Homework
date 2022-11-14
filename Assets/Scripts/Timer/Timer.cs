using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float startTime;

    float currentTime;

    bool isPaused = true;

    bool shouldRepeat;

    public Action OnTimerCompleted;

    public Action OnTimerPaused;

    public Action OnTimerStarted;

    void Start() 
    {
        
    }

    void Update()
    {
        if(currentTime > 0f)
        {
            currentTime -= Time.deltaTime;

                if(currentTime <= 0f)
                {
                    OnTimerCompleted();
                    if(shouldRepeat)
                    {
                        ResetTimer();
                    }
                }
        }
    }

    void ToggleTimerPaused()
    {
        if(isPaused)
        {
            OnTimerStarted?.Invoke();
            isPaused = false;
        }
    }

    public void SetTimer(float newSeconds, Action timerCompletedCallback)
    {
        startTime = newSeconds;
        currentTime = newSeconds;
        OnTimerCompleted += timerCompletedCallback;
    }

    public void ResetTimer() => currentTime = startTime;
}
