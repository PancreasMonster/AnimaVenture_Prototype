using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour {

    public Animator FadeAnim;
    public GameObject PanalFadeIn;
	// Use this for initialization
	void Start () {
        StartCoroutine(Fading());
	}
	
	// Update is called once per frame
	void Update () {
        //FadeAnim.SetTrigger("Start");
        //PanalFadeIn.SetActive(false);
    }
    IEnumerator Fading()
    {
        yield return new WaitForSeconds(3.5f);
        FadeAnim.SetTrigger("Start");
    }
}
