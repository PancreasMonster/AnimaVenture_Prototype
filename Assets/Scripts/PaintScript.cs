﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintScript : MonoBehaviour {

    public GameObject colour;
    private LineRenderer rend;
    public Color LRcolour;
    private Vector3 objPosition;
    int n = 0;
    

	// Use this for initialization
	void Start () {
        colour = GameObject.Find("Handle");
        //rend = this.GetComponent<LineRenderer>();
        //rend.positionCount = 0;
        LRcolour = colour.GetComponent<Image>().color;
        this.gameObject.tag = "Paint";
        this.gameObject.GetComponent<LineRenderer>().SetColors(LRcolour, LRcolour);
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;

        //if (this.gameObject.tag == "Paint")
        //{
            if (Input.GetMouseButtonUp(0))
            {
                //StopAllCoroutines();
                this.gameObject.tag = "Untagged";
                GameObject.Find("PaintBrush").GetComponent<PaintBrushScript>().n = 0;
            }
        //}
        //else { }
        
        
        

    }
    /*
    IEnumerator Paint()
    {
        this.gameObject.GetComponent<LineRenderer>().positionCount += 1;
        this.gameObject.GetComponent<LineRenderer>().SetPosition(n, objPosition);
        n += 1;
        yield return new WaitForSeconds(0.001f);
        StartCoroutine(Paint());
    }
    */

    }

