using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverPin : MonoBehaviour {

    public GameObject sprite;
    AvatarAnim avAnim;
    bool mouseOff;

	// Use this for initialization
	void Start () {
        avAnim = GameObject.FindGameObjectWithTag("Enemy").GetComponent<AvatarAnim>();
	}
	
	// Update is called once per frame
	

    void Update()
    {
        RaycastHit2D hit;
        Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        hit = Physics2D.Raycast(rayPos, Vector2.zero, 100);
        if (hit)
        {
            if (hit.transform.tag == "AncientSite")
            {
                avAnim.LerpTarget(transform.position);
                sprite.SetActive(true);
            }
        } else
        {
            sprite.SetActive(false);
            avAnim.StopLerp();
        }

       
    }

    void OnMouseExit()
    {
       
    }
}
