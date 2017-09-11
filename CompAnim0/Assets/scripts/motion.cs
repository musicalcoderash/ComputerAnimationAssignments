﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class motion : MonoBehaviour {
    private float startTime;
    private float seekTime;
    public Text timer;
    // Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        seekTime = Time.time - startTime;
        if (seekTime >= 20)
            //  Application.Quit();
            timer.text = "TIMER: 20 second(s)";
        else
        {
            timer.text = "TIMER: "+seekTime.ToString("f0")+" second(s)";
            transform.position = new Vector3(5 * seekTime, 5 * seekTime, 0f);
            transform.Rotate(0f, 18 * seekTime, 0f);
            Debug.Log("Time:" + (Time.time - startTime));
        }
	}
}
