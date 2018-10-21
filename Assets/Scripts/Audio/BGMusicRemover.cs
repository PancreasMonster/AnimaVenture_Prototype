using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusicRemover : MonoBehaviour {

    private GameObject BGM;

	// Use this for initialization
	void Start () {
        BGM = GameObject.FindGameObjectWithTag("BG Music");
        Destroy(BGM);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
