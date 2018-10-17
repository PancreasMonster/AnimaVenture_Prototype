using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarAssigner : MonoBehaviour {

    public GameObject draggable;
    private Transform avatar;

	// Use this for initialization
	void Start () {
        avatar = GameObject.FindGameObjectWithTag("CellManager").GetComponent<Transform>();
        avatar.parent = draggable.transform;
        avatar.localPosition = new Vector3(0, 0, 0);
        avatar.rotation = Quaternion.Euler(90, 180, 0);
        avatar.localScale = new Vector3(.2f, .2f, .2f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
