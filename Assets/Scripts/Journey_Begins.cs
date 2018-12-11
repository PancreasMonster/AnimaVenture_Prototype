using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Journey_Begins : MonoBehaviour {

    public float timer;
    public float timerAfterAudio;
    public AudioSource myAudio;
    public string textToShow;
    public Text textBox;
    public string SceneName;

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
        myAudio.Play();
        yield return new WaitForSeconds(timerAfterAudio);
        SceneManager.LoadScene(SceneName);
    }
}
