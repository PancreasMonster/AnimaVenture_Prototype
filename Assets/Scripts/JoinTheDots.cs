﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoinTheDots : MonoBehaviour {
    public GameObject[] dots;
    int dotn = 0;
    public bool held = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnMouseDown()
    {
        held = true;
    }

    private void OnMouseUp()
    {
        held = false;
    }

    void OnMouseDrag()
    {
        foreach (GameObject dot in dots)
        {
            if (dots[dotn].GetComponent<Dot>().fill == true)
            {
                if (dotn < 9)
                {
                    dotn += 1;
                }

                if (dotn == 9)
                {
                    Destroy(this);
                }
            }
        }

        
    }
}
