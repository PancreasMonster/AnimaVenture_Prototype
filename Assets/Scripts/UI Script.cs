using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour {

    public Transform trackingUI;
    public Camera cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 screenPos = cam.WorldToScreenPoint(trackingUI.position);
        Debug.Log("target is " + screenPos.x + " pixels from the left");
    }
}
