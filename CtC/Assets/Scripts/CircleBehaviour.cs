using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CircleBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public int seed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnHit()
    {
        animator.SetBool("Death", true);
        //Destroy(gameObject);
    }
}
