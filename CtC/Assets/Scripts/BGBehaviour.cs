using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGBehaviour : MonoBehaviour
{
   static public int lives= 3;
    public GameObject script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 0) script.GetComponent<GameController>().Gameover();
    }
    private void OnMouseDown()
    {


        lives--;
    }
}
