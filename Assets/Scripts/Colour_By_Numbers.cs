﻿using UnityEngine;


public class Colour_By_Numbers : MonoBehaviour {

    int ColourPalette = 0; 
	// Use this for initialization
	void Start () {
		
	}

    public void OnMouseDown()
    {
        if (gameObject.tag == "Button1")
        {
            ColourPalette = 1;
            Debug.Log("ColourPalette1");
        }
        else if (gameObject.tag == "Button2")
        {
            ColourPalette = 2;
            Debug.Log("ColourPalette2");
        }
        else if (gameObject.tag == "Button3")
        {
            ColourPalette = 3;
            Debug.Log("ColourPalette3");
        }
        else if (gameObject.tag == "Button4")
        {
            ColourPalette = 4;
            Debug.Log("ColourPalette4");
        }
        else if (gameObject.tag == "Button5")
        {
            ColourPalette = 5;
            Debug.Log("ColourPalette5");
        }
        else if (gameObject.tag == "Button6")
        {
            ColourPalette = 6;
            Debug.Log("ColourPalette6");
        }
        else if (gameObject.tag == "Button7")
        {
            ColourPalette = 7;
            Debug.Log("ColourPalette7");
        }
        else if (gameObject.tag == "Button8")
        {
            ColourPalette = 8;
            Debug.Log("ColourPalette8");
        }
        else if (gameObject.tag == "Button9")
        {
            ColourPalette = 9;
            Debug.Log("ColourPalette9");
        }
    }

    // Update is called once per frame
    void Update () {

	}
}
