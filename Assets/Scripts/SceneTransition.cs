using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {


    public Animator transitionAnim;
    public string SceneName;

    public void LoadNextScene()
    {
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneName);
    }

}
