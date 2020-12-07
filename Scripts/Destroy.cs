using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    
    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("canvas");

        for (int i = 0; i < objs.Length; ++i)
        {
            Destroy(objs[i]);
        }
    }

    
}
