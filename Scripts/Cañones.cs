using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañones : MonoBehaviour
{
    public GameObject Player;
    public GameObject Cañones1;
    public float speed = 1f;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rot = Quaternion.LookRotation(Player.transform.position - Cañones1.transform.position);
        Cañones1.transform.rotation = rot;
    }
}
