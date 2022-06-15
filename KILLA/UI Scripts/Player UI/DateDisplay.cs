using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateDisplay : MonoBehaviour
{
    //Private Date integer Object, we don't want people changing it or seeing this.
    private int date;
    private int time;
    //Public text object to be modified and displayed using out hidden knowledge of the date
    public Text calanderText;

    // Update is called once per frame
    void Update()
    {
        calanderText.text = "Day: " + date.ToString() + " Time: " + time.ToString();  
    }

    public void passTime(int timeToPass)
    {
        time += timeToPass;
    }

    public void proceedToNextDay()
    {
        date += 1;
    }
}
