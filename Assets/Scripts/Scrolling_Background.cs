using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling_Background : MonoBehaviour {

    //Background scroll speed can be set in Inspector with Slider
    [Range(1f, 20f)]
    public float scrollSpeed = 1f;

    
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * scrollSpeed * Time.deltaTime);
		if (transform.position.x <= -11.6) {
			transform.Translate (Vector3.right * 11.6f * 2);
		}
	}
}
