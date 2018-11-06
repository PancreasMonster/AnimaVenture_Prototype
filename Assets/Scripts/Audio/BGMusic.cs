using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMusic : MonoBehaviour {

    public AudioSource aud;
    public float SecondsToFade = 1.5f;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
	}

    // Update is called once per frame
    void Update()
    {

    }

    public void ToAvatarScene()
    {
        StartCoroutine(FadeInSound());
        StartCoroutine(TransitionToAvatar());
    }

    IEnumerator FadeInSound()
    {
        
        float rate = 1.0f / SecondsToFade;

        for (float x = 0.0f; x <= 1.0f; x += Time.deltaTime * rate)
        {
            aud.volume = Mathf.Lerp(.1f, 0, x);
           yield return null;
        }
        //yield return new WaitForSeconds(SecondsToFade);
       // SceneManager.LoadScene("PhonePatternScene", LoadSceneMode.Single);
    }

    IEnumerator TransitionToAvatar()
    {
        yield return new WaitForSeconds(SecondsToFade);
        SceneManager.LoadScene("PhonePatternScene", LoadSceneMode.Single);
    }
}
