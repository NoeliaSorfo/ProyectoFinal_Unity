using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  //public Rigidbody rigidbody;

    [SerializeField]
    public float speed = 0;
    public float rotationSpeed = 5;
    public float gravity = -40f;
    public float jumpForce = 10;
    public float playerLife = 100;
    public int timer = 0;
    public GameObject camOne;
    public GameObject camTwo;
    public Vector3 posInicial;

    public Animator anim;
  
    [SerializeField]
    private ForceMode forceMode;

    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    MovePlayer();

        if(Input.GetKeyDown(KeyCode.Return))
        {
        ToggleCamera();
        }

        if(transform.position.y <= -15)
        {
        Respawn(); 
        }

        if(Input.GetKeyDown(KeyCode.Space))
            {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            anim.SetBool("Saltando", true);
            timer = 1;
            }

        if(timer < 120)
        {
            if(timer >= 1)
            {
                timer++;
            }
        }
        else
        {
            anim.SetBool("Saltando", false);
            timer = 0;
        }
    }   

    void MovePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 moveInput = new Vector3(h, 0, v);
        Vector3 velocity = new Vector3(0, 0, v);
        velocity = transform.TransformDirection(velocity);
        velocity *= speed;
        velocity -= GetComponent<Rigidbody>().velocity;

        GetComponent<Rigidbody>().AddForce(velocity, forceMode);
        transform.Rotate(new Vector3(0, h, 0));

        if(Input.GetKey(KeyCode.UpArrow))
        {
        speed = 5;
        if(Input.GetKey(KeyCode.LeftShift))
            {
            speed = 7;
            }
        }
        else
        {
        speed = 0;
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
        speed = 5;
        }

        if (moveInput == Vector3.zero)
        {
            anim.SetBool("Caminando", false);
            anim.SetBool("Corriendo", false);
        }
        else
        {
            anim.SetBool("Caminando", true);
        }

        if(speed == 7)
        {
            anim.SetBool("Corriendo", true);
        }

        if(speed <= 5)
        {
            anim.SetBool("Corriendo", false);
        }
    }

    void ToggleCamera()
        {
        if(camOne.activeInHierarchy)
            {
                camOne.SetActive(false);
                camTwo.SetActive(true);
            }
            else
            {
                camOne.SetActive(true);
                camTwo.SetActive(false);
            }
        }
    void Respawn()
    {
        transform.position = posInicial;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Plane")
            {
                Respawn();
            }

        if(collision.gameObject.name == "Molino1")
            {
                Respawn();
            }

        if(collision.gameObject.name == "Molino2")
            {
                Respawn();
            }
            
        if(collision.gameObject.name == "Bala(Clone)")
            {
                Destroy(collision.gameObject);
                Respawn();
            }

        if(collision.gameObject.name == "Ball_1(Clone)")
            {
                Respawn();
            }

        if(collision.gameObject.name == "Ball_2(Clone)")
            {
                Respawn();
            }

        if(collision.gameObject.name == "Ball_3(Clone)")
            {
                Respawn();
            }

        if(collision.gameObject.name == "Pista")
            {
               anim.SetBool("Saltando", false);
            }

        if(collision.gameObject.name == "Gelatina")
            {
               anim.SetBool("Saltando", false);
            }
/*
        if(col.CompareTag())
            {
               Respawn();
            }*/
    }

    private void OnTriggerEnter(Collider other)
    {
    if (other.gameObject.name == "Eraser")
        {
        posInicial = other.transform.position;
        }

    if (other.gameObject.name == "Finish")
        {
        posInicial = other.transform.position;
        Debug.Log("YOU WIN");
        }
    }
}



