using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintScript : MonoBehaviour {

    public GameObject colour;
    public LineRenderer rend;
    public Color LRcolour;

	// Use this for initialization
	void Start () {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;

        rend = GetComponent<LineRenderer>();

        rend.SetPosition(0, objPosition);
        
    }
	
	// Update is called once per frame
	void Update () {
        LRcolour = colour.GetComponent<Image>().color;
        //rend.SetColors(LRcolour, LRcolour);
    }
}
