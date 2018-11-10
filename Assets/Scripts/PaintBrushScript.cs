﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintBrushScript : MonoBehaviour {

    public GameObject paint;
    public Color LRColour;
    private float LRHue;
    public Slider slider1;
    int n = 0;
    Vector3 objPosition;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;

        LRHue = slider1.value;
        LRColour = Color.HSVToRGB(LRHue, 1, 1);
        slider1.image.color = Color.HSVToRGB(LRHue, 1, 1);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(paint);
            StartCoroutine(Paint());
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopAllCoroutines();
            n = 0;
        }
        

    }

    IEnumerator Paint()
    {
        paint.GetComponent<LineRenderer>().SetPosition(n, objPosition);
        paint.GetComponent<LineRenderer>().positionCount += 1;
        n += 1;
        yield return new WaitForSeconds(0.01f);
        StartCoroutine(Paint());
    }

   

    

}


