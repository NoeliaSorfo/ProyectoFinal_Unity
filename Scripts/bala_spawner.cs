using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala_spawner : MonoBehaviour
{   
    public GameObject Player;
    public GameObject spawner;
    public Rigidbody Bala;
    public Transform PlayerPos;
    public float velocidadBala = 0.001f;
    public int timer = 0;

    void Start()
    {
        //Instantiate(Bala, spawner.transform.position, this.transform.rotation);
    }
    void Update()
    {

    transform.LookAt(new Vector3(PlayerPos.position.x, PlayerPos.position.y, PlayerPos.position.z));

    if(timer <= 1500)
        {
        timer++;
        }

    if(timer == 1500)
        {
            Rigidbody bullet;
            bullet = Instantiate(Bala, spawner.transform.position, spawner.transform.rotation);

            bullet.velocity = transform.TransformDirection(Vector3.forward * velocidadBala);
            timer = 0;
        }

    }

}