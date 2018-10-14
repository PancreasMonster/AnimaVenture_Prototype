using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Transform trackingUI;
    public Camera cam;
    Vector3 restingPlace;

    // Use this for initialization
    void Start()
    {
        restingPlace = new Vector3(75, 100, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cam.ScreenToWorldPoint(restingPlace);
    }

}