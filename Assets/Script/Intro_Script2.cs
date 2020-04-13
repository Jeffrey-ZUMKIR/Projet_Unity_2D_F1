using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_Script2 : MonoBehaviour
{
    //Données membres
    //attribut private public protected
    private int nVal;

    //Lors du chargement de l'instance programme
    void Awake()
    {
        Debug.Log("Awake");
        nVal = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            increase();
            Debug.Log(nVal);
        }
        else
         if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log(decrease());
        }
    }

    //Procedure void()
    void increase()
    {
        nVal++;
    }

    //Fonction int()
    int decrease()
    {
        return nVal--;
    }
}
