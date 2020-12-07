using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PATTERN EN FORMA DE QUADRAT
//INEFICIENT AS FUCK!!!
public class p3 : MonoBehaviour
{

    public float speed = 5f;

    public float xmin = -4.5f;
    public float xmax = -2.5f;
    public float ymin = -2.5f;
    public float ymax = -0.5f;

    private float posx;
    private float posy;

    //marca el moviment inicial
    public bool dreta = true;
    public bool abaix = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        posx = transform.position.x;
        posy = transform.position.y;

        /*if (!abaix && dreta)
        {
            transform.Translate(Vector3.up*speed*Time.deltaTime);
            if (posy>=ymax) abaix = true;
        }
        else if(abaix && dreta)
        {
            transform.Translate(Vector3.right*speed*Time.deltaTime);
            if (posx>=xmax) dreta = false;
        }
        else if(abaix && !dreta)
        {
            transform.Translate(Vector3.down*speed*Time.deltaTime);
            if (posy<=ymin) abaix = false;
        }
        else{
            transform.Translate(Vector3.left*speed*Time.deltaTime);
            if (posx<=xmin) dreta = true;
        }*/

        switch(abaix.ToString() + " " + dreta.ToString()){
            case "False True":
                transform.Translate(Vector3.up*speed*Time.deltaTime);
                if (posy>=ymax) abaix = true;
                break;
            case "True True":
                transform.Translate(Vector3.right*speed*Time.deltaTime);
                if (posx>=xmax) dreta = false;
                break;
            case "True False":
                transform.Translate(Vector3.down*speed*Time.deltaTime);
                if (posy<=ymin) abaix = false;
                break;
            case "False False":
                transform.Translate(Vector3.left*speed*Time.deltaTime);
                if (posx<=xmin) dreta = true;
                break;

            default:
                break;
            }
    }
}
