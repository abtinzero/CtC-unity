using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CircleBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    public int seed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnMouseDown()
    {
        // this object was clicked - do something
        BGBehaviour.lives++;
        GameController.Points++;
        Destroy(gameObject);
    }
  
}
