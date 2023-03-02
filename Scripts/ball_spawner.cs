using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_spawner : MonoBehaviour
{
    public GameObject spawner;
    public GameObject ball;
    public int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ball, spawner.transform.position, spawner.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    if(timer <= 1500)
        {
        timer++;
        }

    if(timer == 1500)
        {
        Instantiate(ball, spawner.transform.position, spawner.transform.rotation);
        timer = 0;
        }
    }
}

