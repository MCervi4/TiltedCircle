using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SEGUEIX ELS POINTS
public class p4 : MonoBehaviour
{

    public float speed = 5f;
    
    private Transform target;
    public int wavepointIndex = 0;

    public int waynum = 0; //de 0 a n

    // Start is called before the first frame update
    void Start()
    {
        target = WayPoints.points[waynum][wavepointIndex];
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 dir = target.position - transform.position;

        transform.Translate(dir.normalized * speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) <= 0.1f)
        {
            GetNextWaypoint();
        }
        
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= WayPoints.points[waynum].Length -1)
        {
            wavepointIndex = -1;
        }
        wavepointIndex++;
        target = WayPoints.points[waynum][wavepointIndex];
    }
}



/*public float speed = 5f;

    private Transform target;
    public int wavepointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = WayPoints.points[wavepointIndex];
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 dir = target.position - transform.position;

        transform.Translate(dir.normalized * speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) <= 0.1f)
        {
            GetNextWaypoint();
        }
        
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= WayPoints.points.Length -1)
        {
            wavepointIndex = -1;
        }
        wavepointIndex++;
        target = WayPoints.points[wavepointIndex];
    }*/