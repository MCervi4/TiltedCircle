using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ABAIX AMUNT
public class p1 : MonoBehaviour
{
    public float speed = 5f;

    public float ymin = -2.5f;
    public float ymax = 2.5f;

    private float posy;

    public bool baixant = true;

    public bool aleatori = false;
    // Start is called before the first frame update
    void Start()
    {
        if (aleatori)
        {
            int random = Random.Range(0,2);
            if (random == 0)
            {
                baixant = false;
            }
            else baixant = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        posy = transform.position.y;
        if (baixant)
        {
            transform.Translate(Vector3.down*speed*Time.deltaTime);
            if (posy<=ymin) baixant = false;
        }
        else{
            transform.Translate(Vector3.up*speed*Time.deltaTime);
            if (posy>=ymax) baixant = true;
        }
    }
}
