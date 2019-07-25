using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CircleBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform prefab;
    
    
    public int seed;
    
    void Start()
    {
        //InvokeRepeating("GenerateCircle", 1, 1f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnMouseDown()
    {
        // this object was clicked - do something
        //Instantiate(prefab, Random.insideUnitCircle * 2, Quaternion.identity);
        GameController.Points++;

        Destroy(gameObject);
       

    }
    public void GenerateCircle()
    {
        Instantiate(prefab, Random.insideUnitCircle * 2, Quaternion.identity);
    }

}
