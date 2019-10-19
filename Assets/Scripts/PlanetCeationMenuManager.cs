using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetCeationMenuManager : MonoBehaviour
{   
    bool isMenuOpen;
    // Start is called before the first frame update
    void Start()
    {
        isMenuOpen=false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void click(){
        Debug.Log("Planet Creation Menu");
        if (isMenuOpen) {
            closeMenu();
        } else {
            openMenu();
        }
        isMenuOpen = !isMenuOpen;
    }
    void openMenu(){
        transform.position = transform.position + new Vector3(200,0,0);
    }
    void closeMenu(){
        transform.position = transform.position + new Vector3(-200,0,0);
    }
}
