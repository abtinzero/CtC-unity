using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mode2Controller : GameController
{
    private float timeleft;

    protected override void Awake()
    {
        base.Awake();
        timeleft = 10;
    }

    void Start()
    {
        Finish.text = "You Win" + Points;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        if (timeleft <= 0)
        {
            Gameover();
        }
        else
        {
            timeleft -= Time.deltaTime;
        }
        Timer.text = "Time: " + ((int)timeleft).ToString();
        Count.text = "Count: " + Points.ToString();
    }
}
