using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarAssigner : MonoBehaviour {

    public GameObject draggable; 

	// Use this for initialization
	void Start () {
        GameObject.FindGameObjectWithTag("CellManager").GetComponent<Transform>().parent = draggable.transform;
        GameObject.FindGameObjectWithTag("CellManager").GetComponent<Transform>().localPosition = new Vector3(0, 0, 0);
        GameObject.FindGameObjectWithTag("CellManager").GetComponent<Transform>().rotation = Quaternion.Euler(90, 180, 0);
        GameObject.FindGameObjectWithTag("CellManager").GetComponent<Transform>().localScale = new Vector3(.2f, .2f, .2f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
