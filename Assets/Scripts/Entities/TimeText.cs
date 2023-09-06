using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    public Text CurrentTime;
    void Update()
    {
        CurrentTime.text = GetTime();
    }
    public static string GetTime()
    {
        return DateTime.Now.ToString(("HH" + ":" + "mm"));
    }
}
