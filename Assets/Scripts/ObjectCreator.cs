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
}
