using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mode1Controller : GameController
{
    public const float kReduceRate = 1.1f, kMinRate = 0.5f;
    public const int kMaxLives = 3;

    [SerializeField] protected float startingWaitTime;

    private float lives, elapsedTime, waitTime;
    private bool added;
    
    protected override void Awake()
    {
        base.Awake();

        lives = kMaxLives;
        waitTime = startingWaitTime;
        elapsedTime = 1;
        added = false;
    }

    void Start()
    {
        //InvokeRepeating("GenerateCircle", 0, rate);
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        
        elapsedTime += Time.deltaTime;
        
        if (((elapsedTime - 1) % waitTime) < (waitTime / 10))
        {
            if (!added)
            {
                added = true;
                waitTime = Mathf.Max(kMinRate, waitTime - Mathf.Log(elapsedTime));
                GenerateCircle();
            }
        }
        else
            added = false;

        if (lives == 0)
            Gameover();
    }

    protected override void OnBackgroundHit()
    {
        base.OnBackgroundHit();
        lives--;
    }
}
