using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro_Script2 : MonoBehaviour
{
    //Données membres
    //attribut private public protected
    private int nVal;

    //Tableau en C# commence à zéro
    string[] sString = new string[4];

    //Lors du chargement de l'instance programme
    void Awake()
    {
        Debug.Log("Awake");
        nVal = 0;

        sString[0] = "Bonjour";
        sString[1] = "Comment allez-vous?";
        sString[2] = "Ca va et toi?";
        sString[3] = "Très bien";

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*for (int i = 0; i<sString.Length; i++)
        {
            Debug.Log(sString[i]);
        }*/

        /*foreach(string str in sString)
        {
            Debug.Log(str);
        }*/

        /*while (test)
        {
            //instructions
        }*/

        /*do
        {
            //instructions
        }while(test);*/

        /*int val = 0;
        switch (val)
        {
            case 1: Debug.Log("blabla");break;
            case 2: ...;break;

            default: ...;break;
        }*/





        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            increase();
        }
        else
         if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            decrease();
        }

        if (nVal >= sString.Length)
        {
            nVal = 0;
        }
        else if (nVal < 0)
        {
            nVal = sString.Length - 1;
        }
        Debug.Log(sString[nVal]);

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
