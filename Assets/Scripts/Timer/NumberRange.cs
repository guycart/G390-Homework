using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NumberRange : MonoBehaviour
{
    float min;

    float max;

    float currentValue;

    [SerializeField] public UnityEvent<float> OnCurrentChanged;

    [SerializeField] public UnityEvent OnMaxReached;

    [SerializeField] public UnityEvent OnMinReached;

    public event System.Action<float> OnCurrentChanged;

    public float MinValue {get => min; set => min = value;}

    public float MaxValue {get => max; set => max = value;}

    public float CurrentValue 
    { 
        get => currentValue;
        set
        {
            currentValue = Mathf.Clamp(value, min, max);
            OnCurrentChanged?.Invoke(currentValue);
            if(currentValue == max)
            {
                OnMaxReached?.Invoke();
            }
             if(currentValue == min)
            {
                OnMinReached?.Invoke();
            }
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
