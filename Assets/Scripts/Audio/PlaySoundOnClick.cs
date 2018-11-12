using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnClick : MonoBehaviour {

    AvatarAnim avAnim;
    AudioSource aud;

    // Use this for initialization
    void Start()
    {
        aud = GetComponent<AudioSource>();
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
                if (hit.transform.tag == "Sound" && !hit.transform.gameObject.GetComponent<AudioSource>().isPlaying)
                {
                    hit.transform.gameObject.GetComponent<AudioSource>().Play();
                }

                if (hit.transform.tag == "Untagged")
                {
                    GetComponent<SpriteRenderer>().enabled = false;
                }
            }
        }
    }



    void OnMouseExit()
    {

    }

}
