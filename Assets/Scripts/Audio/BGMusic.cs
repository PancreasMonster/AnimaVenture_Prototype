using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMusic : MonoBehaviour {

    public AudioSource aud;
    public float SecondsToFade = 1.5f;
    public Animator anim;
    Camera mainCam;

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

    public void ToWorldScene()
    {
        StartCoroutine(FadeInSound());
        StartCoroutine(TransitionToWorldScene());
    }

    public void ToInstructions()
    {
        StartCoroutine(FadeInSound());
        StartCoroutine(TransitionToInstructions());
    }

    public void ToPaintByNumbers(Transform target)
    {
        StartCoroutine(FadeInSound());
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        StartCoroutine(ZoomIn(target));
        StartCoroutine(TransitionToPaintByNumbers());
    }

    public void ToAncientSite()
    {
        StartCoroutine(FadeInSound());
        StartCoroutine(TransitionAncientSite());
    }

    public void ToJourneyScene()
    {
        StartCoroutine(FadeInSound());
        StartCoroutine(TransitionJourneyScene());
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

    IEnumerator FadeOutSound()
    {
        
        float rate = 1.0f / SecondsToFade;

        for (float x = 0.0f; x <= 1.0f; x += Time.deltaTime * rate)
        {
            aud.volume = Mathf.Lerp(0, .1f, x);
            yield return null;
        }
        //yield return new WaitForSeconds(SecondsToFade);
        // SceneManager.LoadScene("PhonePatternScene", LoadSceneMode.Single);
    }

    IEnumerator ZoomIn(Transform target)
    {
        float rate = 1.0f / (SecondsToFade * 8);

        for (float x = 0.0f; x <= 1.0f; x += Time.deltaTime * rate)
        {
            mainCam.transform.position = Vector3.Lerp(mainCam.transform.position, new Vector3(target.position.x, target.position.y, mainCam.transform.position.z), x);
            mainCam.orthographicSize = Mathf.Lerp(mainCam.orthographicSize, 3, x);
            yield return null;
        }
        //yield return new WaitForSeconds(SecondsToFade);
        // SceneManager.LoadScene("PhonePatternScene", LoadSceneMode.Single);
    }

    IEnumerator TransitionToAvatar()
    {
        anim.SetBool("End", true);
        yield return new WaitForSeconds(SecondsToFade);
        StartCoroutine(FadeOutSound());
        SceneManager.LoadScene("PhonePatternScene", LoadSceneMode.Single);
        anim.SetBool("End", false);
    }

    IEnumerator TransitionToInstructions()
    {
        anim.SetBool("End", true);
        yield return new WaitForSeconds(SecondsToFade);
        StartCoroutine(FadeOutSound());
        SceneManager.LoadScene("Instructions", LoadSceneMode.Single);
        anim.SetBool("End", false);
    }

    IEnumerator TransitionToWorldScene()
    {
        anim.SetBool("End", true);
        yield return new WaitForSeconds(SecondsToFade);
        StartCoroutine(FadeOutSound());
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        anim.SetBool("End", false);
    }

    IEnumerator TransitionToPaintByNumbers()
    {
        //yield return new WaitForSeconds(SecondsToFade);
        anim.SetBool("End", true);
        yield return new WaitForSeconds(SecondsToFade);
        StartCoroutine(FadeOutSound());
        SceneManager.LoadScene("NewgrangeScene", LoadSceneMode.Single);
        anim.SetBool("End", false);
    }

    IEnumerator TransitionAncientSite()
    {
        anim.SetBool("End", true);
        yield return new WaitForSeconds(SecondsToFade);
        StartCoroutine(FadeOutSound());
        SceneManager.LoadScene("AncientSiteScene", LoadSceneMode.Single);
        anim.SetBool("End", false);
    }

    IEnumerator TransitionJourneyScene()
    {
        anim.SetBool("End", true);
        yield return new WaitForSeconds(SecondsToFade);
        StartCoroutine(FadeOutSound());
        SceneManager.LoadScene("JourneyScene", LoadSceneMode.Single);
        anim.SetBool("End", false);
    }
}
