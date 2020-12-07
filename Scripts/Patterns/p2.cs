using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//DRETA ESQUERRA
public class p2 : MonoBehaviour
{
    public float speed = 5f;

    public float xmax = 2.5f;
    public float xmin = -2.5f;

    private float posx;

    public bool dreta = true;

    public bool aleatori = false;

    // Start is called before the first frame update
    void Start()
    {
        if (aleatori)
        {
            int random = Random.Range(0,2);
            if (random == 0)
            {
                dreta = false;
            }
            else dreta = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        posx = transform.position.x;
        if (dreta)
        {
            transform.Translate(Vector3.right*speed*Time.deltaTime);
            if (posx>=xmax) dreta = false;
        }
        else{
            transform.Translate(Vector3.left*speed*Time.deltaTime);
            if (posx<=xmin) dreta = true;
        }
    }
}
