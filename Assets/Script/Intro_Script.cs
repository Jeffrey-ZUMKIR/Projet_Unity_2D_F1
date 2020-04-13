using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Type non membre de la classe
/*public struct coord
{


    public coord(int x, int y)
    {
        nX = x;
        nY = y;
    }

    public int nX { get; set; }
    public int nY { get; set; }

}*/
public class Intro_Script : MonoBehaviour
{
    //Type membre de la classe
    public struct Coord
    {
      

        public Coord(int x, int y)
        {
            nX = x;
            nY = y;
        }
        
        public int nX { get; set; }
        public int nY { get; set; }

    }
    // Start is called before the first frame update
    void Start()
    {
        int nA = 10;
        Debug.Log("Ma val est : " + nA);
        float fltReel = 2f;
        double dblReel = 4f;
        char cCar = 'a';
        string sChaine = "Hello World";
        int[] nTab = new int[100];

        Intro_Script.Coord tCoord=new Coord(4,7);

        nA = tCoord.nX;

        tCoord.nX = 2;
        nTab[0] = 0;

        Debug.Log(nA);
        Debug.Log(fltReel);
        Debug.Log(dblReel);
        Debug.Log(cCar);
        Debug.Log(sChaine);
        Debug.Log(tCoord.nX +" et " + tCoord.nY);
        Debug.Log(nTab[0]);
    }

    // Update is called once per frame
    void Update()
    {
        /*float timer = 0f;
        timer += Time.deltaTime;

        Debug.Log("Delta Time :" + timer);*/

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Key pressed up Arrow");
        }else
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Key pressed down Arrow");
        }else
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Key pressed enter");
        }





    }
}
