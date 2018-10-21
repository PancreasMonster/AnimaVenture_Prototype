using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverPin : MonoBehaviour {

    public GameObject sprite;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseOver()
    {
        sprite.SetActive(true);
    }

    void OnMouseExit()
    {
        sprite.SetActive(false);
    }
}
