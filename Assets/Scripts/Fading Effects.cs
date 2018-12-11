using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadingEffects : MonoBehaviour {

    float t = 1;
    public TrailRenderer tr;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        t -= Time.deltaTime * (1 / 10);

        tr.endColor = new Color(tr.endColor.r, tr.endColor.g, tr.endColor.b, t);
        tr.startColor = new Color(tr.startColor.r, tr.startColor.g, tr.startColor.b, t);

    }
}
