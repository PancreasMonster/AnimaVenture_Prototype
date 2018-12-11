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
    public float SecondsToFade;

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
        StartCoroutine(FadeInSound());
        yield return new WaitForSeconds(timerAfterAudio);
        SceneManager.LoadScene(SceneName);
    }

    IEnumerator FadeInSound()
    {

        float rate = 1.0f / SecondsToFade;

        for (float x = 0.0f; x <= 1.0f; x += Time.deltaTime * rate)
        {
            myAudio.volume = Mathf.Lerp(0, .25f, x);
            yield return null;
        }
        //yield return new WaitForSeconds(SecondsToFade);
        // SceneManager.LoadScene("PhonePatternScene", LoadSceneMode.Single);
    }
}
