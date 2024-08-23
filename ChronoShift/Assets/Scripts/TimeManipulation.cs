using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManipulation : MonoBehaviour
{
    private float fixedDeltaTime;

    [Header("Keybinds")]
    public KeyCode slowTime = KeyCode.Mouse1;

    public KeyCode speedTime = KeyCode.Mouse2;

    [Header("Time Scales")]
    public float slowTimeSpeed;

    public bool isTimeSlowed;
    public float fastTimeSpeed;
    public bool isTimeSpedUp;

    private void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(slowTime))
        {
            if (Time.timeScale == 1.0f)
            {
                Time.timeScale = slowTimeSpeed;
                isTimeSlowed = true;
            }
            else
            {
                Time.timeScale = 1.0f;
                isTimeSlowed = false;
            }
            Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
        }

        if (Input.GetKeyDown(speedTime))
        {
            if (Time.timeScale == 1.0f)
            {
                Time.timeScale = fastTimeSpeed;
                isTimeSpedUp = true;
            }
            else
            {
                Time.timeScale = 1.0f;
                isTimeSpedUp = false;
            }
            Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
        }
    }
}