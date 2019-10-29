using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBG : MonoBehaviour
{
    // Start is called before the first frame update
    public float BGspeed = 50;
    bool increasesizebg = true;
    public float scalespeed = 0.1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * BGspeed * Time.deltaTime);
        if (transform.localScale.x <= 10)
            increasesizebg = true;
        else if (transform.localScale.x >= 20)
            increasesizebg = false;
        increase_size();
    }

    void increase_size()
    {
        if (increasesizebg == false) transform.localScale += new Vector3(-scalespeed, -scalespeed, 0);
        else transform.localScale += new Vector3(scalespeed, scalespeed, 0);
    }
}
