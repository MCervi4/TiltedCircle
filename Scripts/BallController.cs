using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BallController : MonoBehaviour
{

    public float speed = 5f;

    public GameController gc;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //dreta
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right*speed*Time.deltaTime;
        }
        //esquerra
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left*speed*Time.deltaTime;
        }
        //amunt
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up*speed*Time.deltaTime;
        }
        //aball
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down*speed*Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Triangle")
        {
            
            gc.ReloadScene();
            gc.Death();
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        gc.NextLevel();
    }

}

