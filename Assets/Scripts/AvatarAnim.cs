using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarAnim : MonoBehaviour {

    public float lerpSpeed = 1, radius = 2;
    float theta;
    Vector3 lerpTowards;
    Vector3 originalPos;
    bool startLerping;
    public Transform target;

	// Use this for initialization
	void Start () {
        //LerpTarget(target);
        originalPos = transform.position;
        Debug.Log(originalPos);
	}
	
	// Update is called once per frame
	void Update () {
		if (startLerping)
        {
            theta += lerpSpeed * Time.deltaTime;
            transform.localPosition += (Mathf.Sin(theta) * lerpTowards * radius * Time.deltaTime);
           // transform.position.z = new Vec
        }
	}

    public void LerpTarget (Vector3 target)
    {
        lerpTowards = target - transform.position;
        lerpTowards.Normalize();
        startLerping = true; 
    }

    public void StopLerp ()
    {
        //theta = 0;
        startLerping = false;
        //transform.position = originalPos;
        Debug.Log(lerpTowards);
    }
}
