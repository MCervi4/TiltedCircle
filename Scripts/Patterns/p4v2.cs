using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SEGUEIX ELS POINTS
//VERSIO PASSANT PELS MATEIXOS DE TORNADA
public class p4v2 : MonoBehaviour
{

    public float speed = 5f;
    
    private Transform target;
    public int wavepointIndex = 0;

    public int waynum = 0; //de 0 a n

    private bool endevant = true;
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
           
            endevant = false;
        }
        if (wavepointIndex <= 0)
        {
            
            endevant = true;
        }
        if (endevant)
        {
            
            wavepointIndex++;
            target = WayPoints.points[waynum][wavepointIndex];
        }
        else
        {
            wavepointIndex--;
            target = WayPoints.points[waynum][wavepointIndex];
        }
        
    }
}
