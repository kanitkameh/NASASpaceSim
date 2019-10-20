using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceObject : MonoBehaviour
{
    public double temperature; //in Kelvins
    float mass;
    float radius; //in meters
    float volume; //in km^3
    float density; 
    public int rotationPeriod; //in seconds
    void Start(){
        init();
    }
    public virtual void init(){
        Rotate r = gameObject.AddComponent<Rotate>();
        r.periodTime = rotationPeriod;
    }
}
