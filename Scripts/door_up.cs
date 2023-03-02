using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_up : MonoBehaviour
{
  public int timer = 0;
  public int timer2 = 0;
  public int reset = 0;

  void Start()
  {
		
  }

  void Update()
  {
    switch (reset)
    {
      case 0:
        transform.position += Vector3.down * 0.005f;
        if (timer < 400)
        {
          timer++;
        }
        else
        {
          reset = 2;
        }
        break;
      case 1:
      transform.position += Vector3.up * 0.005f;
        if (timer > 0)
        {
          timer--;
        }
        else
        {
          reset = 3;
        }
        break;
      case 2:
        timer2++;
        break;
      case 3:
        timer2++;
        break;
    }

    //DELAY
    if (timer2 > 1200)
    {
      if (reset == 2)
      {
        reset = 1;
        timer2 = 0;
      }
    }

    if (timer2 > 1200)
    {
      if (reset == 3)
      {
        reset = 0;
        timer2 = 0;
      }
    }
		
  }
}