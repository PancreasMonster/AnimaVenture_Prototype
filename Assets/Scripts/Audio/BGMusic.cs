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
        StartCoroutine(TransitionToWorldScene());
    }

    public void ToPaintByNumbers(Transform target)
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        StartCoroutine(ZoomIn(target));
        StartCoroutine(TransitionToPaintByNumbers());
    }

    public void ToAncientSite()
    {
        StartCoroutine(TransitionAncientSite());
    }

    IEnumerator FadeInSound()
    {
        anim.SetBool("End", true);
        float rate = 1.0f / SecondsToFade;

        for (float x = 0.0f; x <= 1.0f; x += Time.deltaTime * rate)
        {
            aud.volume = Mathf.Lerp(.1f, 0, x);
           yield return null;
        }
        //yield return new WaitForSeconds(SecondsToFade);
       // SceneManager.LoadScene("PhonePatternScene", LoadSceneMode.Single);
    }

    IEnumerator ZoomIn(Transform target)
    {
        float rate = 1.0f / SecondsToFade;

        for (float x = 0.0f; x <= 1.0f; x += Time.deltaTime * rate)
        {
            mainCam.transform.position = Vector3.Lerp(mainCam.transform.position, target.position, x);
            mainCam.orthographicSize = Mathf.Lerp(mainCam.orthographicSize, 3, x);
            yield return null;
        }
        //yield return new WaitForSeconds(SecondsToFade);
        // SceneManager.LoadScene("PhonePatternScene", LoadSceneMode.Single);
    }

    IEnumerator TransitionToAvatar()
    {
        yield return new WaitForSeconds(SecondsToFade);
        SceneManager.LoadScene("PhonePatternScene", LoadSceneMode.Single);
        anim.SetBool("End", false);
    }

    IEnumerator TransitionToWorldScene()
    {
        anim.SetBool("End", true);
        yield return new WaitForSeconds(SecondsToFade);
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        anim.SetBool("End", false);
    }

    IEnumerator TransitionToPaintByNumbers()
    {
        anim.SetBool("End", true);
        yield return new WaitForSeconds(SecondsToFade);
        SceneManager.LoadScene("NewgrangeScene", LoadSceneMode.Single);
        anim.SetBool("End", false);
    }

    IEnumerator TransitionAncientSite()
    {
        anim.SetBool("End", true);
        yield return new WaitForSeconds(SecondsToFade);
        SceneManager.LoadScene("AncientSiteScene", LoadSceneMode.Single);
        anim.SetBool("End", false);
    }
}
