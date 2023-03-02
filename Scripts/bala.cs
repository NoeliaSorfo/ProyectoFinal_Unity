using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public int timer = 0;

    void Start()
    {

    }

    void Update()
    {   
        timer++;
        
        if(timer >= 1500)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
    if (other.gameObject.name == "Eraser")
        {
        Destroy(this.gameObject);
        }
    }
}


