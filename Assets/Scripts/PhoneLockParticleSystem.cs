﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneLockParticleSystem : MonoBehaviour {


    public float Distance = 10;
    public AudioSource aud;
    public float distance;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {


            Ray ray;
            RaycastHit hit;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
<<<<<<< HEAD
                transform.position = new Vector3(hit.point.x, hit.point.y, hit.point.z + distance);
=======
                transform.position = new Vector3(hit.point.x, hit.point.y, hit.point.z + 1);
>>>>>>> parent of 06bfbb4... Merge branch 'Testing' of https://github.com/PancreasMonster/AnimaVenture_Prototype into Testing
            }
            if (!aud.isPlaying && aud != null)
            {
                aud.Play();
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            aud.Stop();
        }
    }
}
