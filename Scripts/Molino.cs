using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molino : MonoBehaviour
{
  public int speed = 50;

  void Start()
  {
		
  }

  void Update()
  {
		transform.RotateAround(transform.position, Vector3.left, speed * Time.deltaTime);
  }
}