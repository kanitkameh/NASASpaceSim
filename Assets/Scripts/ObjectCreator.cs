using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
public class ObjectCreator : MonoBehaviour
{
    public void createSun(){
        GameObject starObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        double tempInKelvins;
        if(double.TryParse(GameObject.Find ("StarTemperatures").GetComponent<InputField>().text,out tempInKelvins)){
            Debug.Log("Temperature input is correct: "+tempInKelvins);
        }else{
            Debug.Log("ERROR: Temperature input is correct");
        }
        starObj.transform.position = new Vector3(0, 0, 0);
        Star star = starObj.AddComponent<Star>();
        star.temperature=tempInKelvins;
    }
    public void createPlanet(){
        GameObject planetObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        double planetRadius;
        if(double.TryParse(GameObject.Find("PlanetRadiusInput").GetComponent<InputField>().text,out planetRadius)){
            Debug.Log("PLanet radius is legit");
        }else{
            Debug.Log("Planet incorrect radius value");
        }
        double distanceFromSun;
        if(double.TryParse(GameObject.Find("DistanceFromSunInput").GetComponent<InputField>().text,out distanceFromSun)){
            Debug.Log("PLanet distance from sun is legit");
        }else{
            Debug.Log("Planet incorrect distance from sun value");
        }

        planetObj.transform.position = new Vector3((float)distanceFromSun,0,0);
        Planet planet = planetObj.AddComponent<Planet>();
        EllipticalRotation ellipticalRotationScript = planetObj.AddComponent<EllipticalRotation>();
        ellipticalRotationScript.scaleFactorX=(float)distanceFromSun;
        ellipticalRotationScript.scaleFactorY=(float)distanceFromSun;
        ellipticalRotationScript.centerX=0;
        ellipticalRotationScript.centerY=0;
        //planet.rotationPeriod = 1;
        
    }
}
