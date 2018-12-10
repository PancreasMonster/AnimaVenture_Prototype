using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FADINGBUBBLE : MonoBehaviour {
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
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit;
            Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            hit = Physics2D.Raycast(rayPos, Vector2.zero, 100);
            if (hit)
            {
                if (hit.transform.tag == "People")
                {
                    // avAnim.LerpTarget(transform.position);
                    hit.transform.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                }
            }
            else
            {
                sprite.SetActive(false);
                //   avAnim.StopLerp();
            }
        }
       
    }

    void OnMouseExit()
    {
     
	}

    IEnumerator FadeImage()
    {
        yield return new WaitForSeconds(0);
    }
}
