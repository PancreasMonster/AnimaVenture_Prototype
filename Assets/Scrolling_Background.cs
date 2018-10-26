using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling_Background : MonoBehaviour {

    //Background scroll speed can be set in Inspector with Slider
    [Range(1f, 20f)]
    public float scrollSpeed = 1f;

    //Scroll Offset Value to smoothly repeat background movement
    public float scrollOffset;

    //start position of background movement
    Vector2 startPos;

    //backgrounds new position
    float newPos;

	// Use this for initialization
	void Start () {
        //getting background's start position
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        //calculating new backgrounds position repeating it depending on scroll Offset
        newPos = Mathf.Repeat(Time.time * -scrollSpeed, scrollOffset);
        //Setting new Position
        transform.position = startPos + Vector2.right * newPos;
	}
}
