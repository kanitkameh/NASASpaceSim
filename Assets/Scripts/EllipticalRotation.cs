using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllipticalRotation : MonoBehaviour
{
    public float scaleFactorX, scaleFactorY, centerX ,centerY, currentX, currentY; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
     currentX =  centerX + (scaleFactorX * Mathf.Cos(Time.time));
     currentY =  centerY + (scaleFactorY * Mathf.Sin(Time.time));
     transform.position = new Vector3(currentX,currentY,0);
    }
}