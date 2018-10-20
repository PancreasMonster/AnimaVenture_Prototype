using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class White_Piece_Colour_Change : MonoBehaviour {

    private Colour_By_Numbers CBN;
    public int ColourChecker;
    // Use this for initialization
    void Start () {
        CBN = GameObject.FindGameObjectWithTag("ColourByNumbers").GetComponent<Colour_By_Numbers>();
	}

    private void OnMouseDown()
    {
        if (CBN.CurrentColour == ColourChecker)
        {
            Destroy(this.gameObject);
        }
    }
    
    // Update is called once per frame
    void Update () {
		
	}
}
