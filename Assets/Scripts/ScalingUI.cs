using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingUI : MonoBehaviour {

    private float orthoOrg;
    private float orthoCurr;
    private Vector3 scaleOrg;
    private Vector3 posOrg;
    public Camera cam;

    void Start()
    {
        orthoOrg = cam.orthographicSize;
        orthoCurr = orthoOrg;
        scaleOrg = transform.localScale;
        posOrg = cam.WorldToViewportPoint(transform.position);
    }
    void Update()
    {
        var osize = Camera.main.orthographicSize;
        if (orthoCurr != osize)
        {
            transform.localScale = scaleOrg * osize / orthoOrg;
            orthoCurr = osize;
            transform.position = cam.ViewportToWorldPoint(posOrg);
        }

    }
}
