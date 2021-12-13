using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private DateTime m_TimeToNY;

    [SerializeField] private Text m_Days, m_Hours, m_Minutes, m_Seconds;

    private TimeSpan m_TimeLeft;
    
    void Start()
    {
        m_TimeToNY = new DateTime(2022,01,01,00,00,00);
    }

    // Update is called once per frame
    void Update()
    {
        m_TimeLeft = m_TimeToNY - DateTime.Now;
        m_Days.text = m_TimeLeft.Days.ToString();
        m_Hours.text = m_TimeLeft.Hours.ToString();
        m_Minutes.text = m_TimeLeft.Minutes.ToString();
        m_Seconds.text = m_TimeLeft.Seconds.ToString();
    }
}
