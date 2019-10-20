using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Star : SpaceObject{
    char starClass;
    List<Planet>planets;
    void Start(){
        init();
    }
    public override void init(){
        base.init();
        planets = new List<Planet>();
        GetComponent<Renderer>().material.color = StarTemperatureUtils.getColorFromStarTemperature(temperature);
    }
}