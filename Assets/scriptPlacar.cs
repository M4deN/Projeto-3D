using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scriptPlacar : MonoBehaviour
{
    public static int placar = 0;
    private static GameObject txtPlacar;
    // Start is called before the first frame update
    void Start()
    {
        txtPlacar = GameObject.Find("txtPlacar");
    }
    public static void incrementarPlacar(int inc)
    {
        placar = placar + inc;

        txtPlacar.GetComponent<Text>().text = "PLACAR:" + placar;
           
    }
}
