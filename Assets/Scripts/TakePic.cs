using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Screen()
    {
        ScreenCapture.CaptureScreenshot("Drawings");
    }
}
