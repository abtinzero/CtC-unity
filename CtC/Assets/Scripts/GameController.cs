using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameController : MonoBehaviour
{
    [SerializeField] Text Timer;
    [SerializeField] Text Count;
    [SerializeField] Text Finish;
    [SerializeField] float Timeleft;
    [SerializeField] float rate;
    [SerializeField] Transform prefab;
    float time;
    float Globaltime;
    public float interpolationPeriod;
    public static int Points=0;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            Finish.text = "You Win" + Points;
            
        }
        if (SceneManager.GetActiveScene().name == "Mode1")
        {
            //InvokeRepeating("GenerateCircle", 0, rate);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        Globaltime += Time.deltaTime;
        rate += 0.1f;
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            if (Timeleft <= 0)
            {
                Gameover();
            }
            else
            {
                Timeleft -= Time.deltaTime;
            }
            Timer.text = "Time: " + ((int)Timeleft).ToString();
            Count.text = "Count: " + Points.ToString();
        }
        if (SceneManager.GetActiveScene().name == "Mode1")
        {
            time += Time.deltaTime;

            if (time >= interpolationPeriod)
            {
                
                time = 0;
                interpolationPeriod = (5 / (Globaltime*0.5f));
                GenerateCircle();
                
            }
        }

    }
    void Gameover()
    {
        Points = 0;
        SceneManager.LoadScene("MainMenu");
        //Finish.enabled = true;
        //Finish.text = "Finish: " + Points.ToString();
    }
    public void GenerateCircle()
    {
        Instantiate(prefab, Random.insideUnitCircle * 2, Quaternion.identity);
    }
    
}
