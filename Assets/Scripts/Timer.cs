using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject gameManager;

    private Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerText = GetComponent<Text>();
        float secondsLeft = gameManager.GetComponent<GameManager>().getSecondsLeft();
        timerText.text = secondsLeft.ToString();
        if (secondsLeft <= 10)
        {
            timerText.color = Color.red;
        }
    }
}
