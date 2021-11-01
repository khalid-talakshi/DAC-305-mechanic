using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float nextActionTime = 0.0f;
    private float period = 1.0f;

    public float secondsLeft = 30.0f;

    public float getSecondsLeft()
    {
        return secondsLeft;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameManager has started");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            Debug.Log("Timer has ticked");
            nextActionTime = Time.time + period;
            secondsLeft -= 1.0f;
        }
    }
}
