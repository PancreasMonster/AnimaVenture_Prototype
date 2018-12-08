using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void PlayAnimation()
    {
        GetComponent<Animator>().SetBool("Clicked", true);
    }

    public void StopAnimation()
    {
        GetComponent<Animator>().SetBool("Clicked", false);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
