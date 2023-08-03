using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockAnalog : MonoBehaviour
{
    //[SerializeField] private GameObject _secondHand;
    //[SerializeField] private GameObject _minuteHand;
    //[SerializeField] private GameObject _hourHand;
    //private string oldSeconds;


    //private void Update()
    //{
    //    string seconds = System.DateTime.UtcNow.ToString("ss");

    //    if(seconds != oldSeconds)
    //    {
    //        UpdateTimer();
    //    }
    //    oldSeconds = seconds;
    //}

    //private void UpdateTimer()
    //{
    //    int secondsInt = int.Parse(System.DateTime.UtcNow.ToString("ss"));
    //    int minutesInt = int.Parse(System.DateTime.UtcNow.ToString("mm"));
    //    int hoursInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("hh"));

    //    iTween.RotateTo(_secondHand, iTween.Hash("y", secondsInt * 6 ,"islocal",true, "time", 1, "easetype", "easeOutQuint"));
    //    iTween.RotateTo(_minuteHand, iTween.Hash("y", minutesInt * 6 , "islocal", true, "time", 1, "easetype", "easeOutElastic"));
    //    float hourDistance =(float)(minutesInt) / 60f;
    //    iTween.RotateTo(_hourHand, iTween.Hash("y",(hoursInt +hourDistance) * 360 / 12, "islocal", true, "time", 1, "easetype", "easeOutElastic"));
    //}
}
