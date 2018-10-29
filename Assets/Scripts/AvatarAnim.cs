using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarAnim : MonoBehaviour {

    public float lerpSpeed = 1, radius = 2;
    float theta;
    Vector3 lerpTowards;
    Vector3 originalPos;
    bool startLerping;
    public Transform particleTransform;
    ParticleSystem ps;
    public Transform target;

	// Use this for initialization
	void Start () {
        //LerpTarget(target);
        originalPos = Camera.main.WorldToViewportPoint(transform.position);
        // Debug.Log(originalPos);
       // particleTransform = GetComponentInChildren<Transform>();
        ps = GetComponentInChildren<ParticleSystem>();
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
        particleTransform.rotation = Quaternion.LookRotation(lerpTowards);
        if (!ps.isPlaying) 
        ps.Play();
        if(ps.isPlaying)
        ps.startLifetime = Vector3.Distance(transform.position, target)/5;
        startLerping = true; 
    }

    public void StopLerp ()
    {
        theta = 0;
        startLerping = false;
        transform.position = Camera.main.ViewportToWorldPoint(originalPos);
        ps.Stop();
       // Debug.Log(lerpTowards);
    }

}
