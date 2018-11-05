using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBrushScript : MonoBehaviour {

    public GameObject paint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(paint);
        }

        }

    
}
