using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoinTheDots : MonoBehaviour {
    public GameObject[] dots;
    int dotn = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(dotn);

        foreach (GameObject dot in dots)
        {
            if(dots[dotn].GetComponent<Dot>().fill == true)
            {
                dotn += 1;
            }
        }

        if( dotn == dots.Length - 1)
        {
            Destroy(this);
        }
	}
}
