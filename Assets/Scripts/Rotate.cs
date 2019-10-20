using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float periodTime; //in seconds
    // Start is called before the first frame update
    void Start()
    {
        //we do this to avoid division by zero in the Update()
        if(periodTime==0)
            periodTime=4; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,360/periodTime,0) * Time.deltaTime ,Space.Self);
    }
}
