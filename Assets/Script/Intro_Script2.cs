using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro_Script2 : MonoBehaviour
{
    //Données membres
    //attribut private public protected
    private int nVal;

    //Tableau en C# commence à zéro
    //string[] sString = new string[4];
    //public string[] sString;
    [SerializeField] string[] sString=default;
    //SerializeField
    [SerializeField] State StartingState;

    //private member
    State state;
    Text MainText;

    State[] tArrayState;
    //Lors du chargement de l'instance programme
    void Awake()
    {
        Debug.Log("Awake");
        nVal = 0;

        /*sString[0] = "Bonjour";
        sString[1] = "Comment allez-vous?";
        sString[2] = "Ca va et toi?";
        sString[3] = "Très bien";*/

    }
    // Start is called before the first frame update
    void Start()
    {
        //MainText = GetComponentInChildren<Text>();
        
        //Debug.Log(MainText.name);
        //MainText.text = "Salut";
        state = StartingState;

        //state = State.CreateInstance<State>();
        //Debug.Log("Name state :" + state.name);
        //state.setStateStory(" lobortis augue vitae metus imperdiet, a laoreet turpis suscipit." +
        //    " Nunc pharetra condimentum turpis, ut mollis mi convallis in." + " Nulla facilisi. Integer turpis sem, lacinia ut ornare at, egestas nec dolor. " +
        //    "Quisque cursus ex vel finibus rutrum. Phasellus semper consectetur commodo. Proin vel lacus nunc. Sed felis");


        MainText = GameObject.Find("MainText").GetComponent<Text>();

        if (state != null)
        {
            MainText.text = state.GetSateStory();
        }
        else
        {
            Debug.Log("SerializeField StartingState is not set");
        }
        tArrayState = state.GetNextStates();


    }

    // Update is called once per frame
    void Update()
    {
        //MainText.text = tArrayState[0].GetSateStory();

        manageState();




        //switchIndexTab();
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



        //Debug.Log(sString[nVal]);
        /*MainText.text = sString[nVal];
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (nVal >= sString.Length)
            {
                nVal = 0;
            }
            else if (nVal < sString.Length - 1)
            {
                increase();
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (nVal < 0)
            {
                nVal = sString.Length - 1;
            }
            else if (nVal > 0)
            {
                decrease();
            }
        }*/

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

    void switchIndexTab()
    {
        MainText.text = sString[nVal];
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (nVal >= sString.Length)
            {
                nVal = 0;
            }
            else if (nVal < sString.Length - 1)
            {
                increase();
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (nVal < 0)
            {
                nVal = sString.Length - 1;
            }
            else if (nVal > 0)
            {
                decrease();
            }
        }
    
    }
    private void manageState()
    {
        var nextStates = tArrayState;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            state = nextStates[3];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            state = nextStates[4];
        }

        MainText.text = state.GetSateStory();


    }
}
