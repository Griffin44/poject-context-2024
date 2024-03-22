using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private float time = 0;
    public UnityEvent OnTimerDone = new UnityEvent();
    

    // Update is called once per frame
    void Update()
    {
        if (time < 0) return;
        time -= Time.deltaTime;
        if (time <= 0)
        {
            OnTimerDone.Invoke();
        }
    }
}
