using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour {

    public float Distance = 10;
    public AudioSource aud;

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton (0))
        {


            Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 pos = r.GetPoint(Distance);

            transform.position = pos;
            if(!aud.isPlaying)
            {
                aud.Play();
            }
        }
	}
}
