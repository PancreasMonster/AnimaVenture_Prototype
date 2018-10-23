using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverPin : MonoBehaviour {

    public GameObject sprite;
    AvatarAnim avAnim;

	// Use this for initialization
	void Start () {
        avAnim = GameObject.FindGameObjectWithTag("Enemy").GetComponent<AvatarAnim>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseOver()
    {
        sprite.SetActive(true);
    }

    void OnMouseEnter()
    {
        avAnim.LerpTarget(transform.position);
    }

    void OnMouseExit()
    {
        sprite.SetActive(false);
        avAnim.StopLerp();
    }
}
