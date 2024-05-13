using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Timers;
using UnityEngine;

public class TimerTime : MonoBehaviour
{
    private float _seconds = 0f;
    private float _minutes = 0f;
    private float _hours = 0f;

    // Update is called once per frame
    void Update()
    {
        _seconds += 1 * Time.deltaTime;

        float tempSeconds = Mathf.Floor(_seconds),
              tempMinutes = Mathf.Floor(_minutes),
              tempHours   = Mathf.Floor(_hours);

        if (tempSeconds == 60)
        {
            _seconds = 0;
            _minutes++;
        }
        if (tempMinutes == 60)
        {
            _minutes = 0;
            ++_hours;
        }

        string textData = "";
        // hours
        if (tempHours < 10)
        {
            textData += "0" + tempHours.ToString() + ':';
        }
        else
        {
            textData += tempHours.ToString();
        }

        // minutes
        if (tempMinutes < 10)
        {
            textData += "0" + tempMinutes.ToString() + ':';
        }
        else
        {
            textData += tempMinutes.ToString();
        }

        // seconds
        if (tempSeconds < 10)
        {
            textData += "0" + tempSeconds.ToString();
        }
        else
        {
            textData += tempSeconds.ToString();
        }

        GetComponent<Text>().text = textData;
        
    }
}
