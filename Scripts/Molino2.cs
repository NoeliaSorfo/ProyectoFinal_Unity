using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molino2 : MonoBehaviour
{
  public int speed = 50;

  void Start()
  {
		
  }

  void Update()
  {
		transform.RotateAround(transform.position, Vector3.right, speed * Time.deltaTime);
  }
}