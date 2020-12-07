using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ROTACIO Z

public class p5 : MonoBehaviour
{

    public float speed = 10f;

    //rota horari o antihorari

    public bool horari = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (horari)
        {
            transform.Rotate(new Vector3(0,0,-1)*speed*Time.deltaTime);
        }
        else {
            transform.Rotate(new Vector3(0,0,1)*speed*Time.deltaTime);
        }
    }
}
