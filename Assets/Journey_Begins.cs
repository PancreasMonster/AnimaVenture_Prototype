using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Journey_Begins : MonoBehaviour {

    public float timer;
    public AudioSource myAudio;
    public string textToShow;
    public Text textBox;
    public GameObject ParticleSystem;

	// Use this for initialization
	void Start () {
        StartCoroutine("BeginJourney");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator BeginJourney()
    {
        yield return new WaitForSeconds(timer);
        textBox.text = textToShow;
        yield return new WaitForSeconds(timer);
        textBox.text = "";
        ParticleSystem.SetActive(false);
        myAudio.Play();
    }
}
