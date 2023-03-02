using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
  public int speed = 50;

  void Start()
  {
		
  }

  void Update()
  {
		transform.RotateAround(transform.position, Vector3.down, speed * Time.deltaTime);
  }
}