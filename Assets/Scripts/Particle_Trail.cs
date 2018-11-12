using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Trail : MonoBehaviour {

    private TrailRenderer trail;
    public float Distance;

    // Use this for initialization
    void Start () {
        trail = GetComponent<TrailRenderer>();
        //Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(1)) 
        {
            trail.startColor = Color.red;
            trail.endWidth = 5;
        }

        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 pos = r.GetPoint(Distance);

        transform.position = pos;
    }
}
