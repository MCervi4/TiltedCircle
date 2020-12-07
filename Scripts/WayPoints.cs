using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    public static Transform[][] points;


    void Awake()
    {
        //cada fill es un cami
        int numways = transform.childCount;
        
        points = new Transform[numways][];

        for (int n = 0; n < numways; ++n) {

            points[n] = new Transform[transform.GetChild(n).childCount];

            for (int i = 0; i < points[n].Length; ++i) 
            {
                points[n][i] = transform.GetChild(n).GetChild(i);
                
            }

        }
        
    }
}



/*public static Transform[] points;

    void Awake()
    {
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; ++i) 
        {
            points[i] = transform.GetChild(i);
        }
        
    }*/