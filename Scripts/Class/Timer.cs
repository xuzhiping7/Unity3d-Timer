using UnityEngine;
using System;
using System.Collections;

//Coded by ZhipingXu  xuzhiping7@qq.com 
//Too simple, so I do not need to explain, just see the code. Help yourself.

public class Timer{

    //If the Timer is running 
    private bool b_Tricking;

    //Current time
    private float f_CurTime;

    //Time to reach
    private float f_TriggerTime;

    //Use delegate to hold the methods
    public delegate void EventHandler();

    //The trigger event list
    public event EventHandler tick;

    /// <summary>
    /// Init
    /// </summary>
    /// <param name="second">Trigger Time</param>
    public Timer(float second)
    {
        f_CurTime = 0.0f;
        f_TriggerTime = second;
    }
    
    /// <summary>
    /// Start Timer
    /// </summary>
	public void Start()
    {
        b_Tricking = true;
    }
    
    /// <summary>
    /// Update Time
    /// </summary>
    public void Update()
    {
        if (b_Tricking)
        {
            f_CurTime += Time.deltaTime;

            if (f_CurTime > f_TriggerTime)
            {
                tick();
                b_Tricking = false;
            }
        }
    }

    /// <summary>
    /// Stop the Timer
    /// </summary>
    public void Stop()
    {
        b_Tricking = false;
    }

    /// <summary>
    /// Continue the Timer
    /// </summary>
    public void Continue()
    {
        b_Tricking = true;
    }

    /// <summary>
    /// Restart the this Timer
    /// </summary>
    public void Restart()
    {
        b_Tricking = true;
        f_CurTime = 0.0f;
    }

    /// <summary>
    /// Change the trigger time in runtime
    /// </summary>
    /// <param name="second">Trigger Time</param>
    public void ResetTriggerTime(float second)
    {
        f_TriggerTime = second;
    }
}
