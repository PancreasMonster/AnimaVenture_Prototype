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


            Ray ray;
            RaycastHit hit;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                transform.position = new Vector3(hit.point.x, hit.point.y, hit.point.z + 1);
            }
            if (!aud.isPlaying && aud != null)
            {
                aud.Play();
            }
        }

        if (Input.GetMouseButtonUp (0))
        {
            aud.Stop();
        }
	}
}
