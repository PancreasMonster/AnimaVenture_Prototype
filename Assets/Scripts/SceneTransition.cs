using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {


    public Animator transitionAnim;
    public string SceneName;
    BGMusic bgm;
    public Transform target;
    Camera mainCam;

    private void Start()
    {
        bgm = GameObject.FindGameObjectWithTag("BG Music").GetComponent<BGMusic>();
    }

    public void LoadNextScene()
    {
        bgm.ToPaintByNumbers(target);
    }

    public void LoadAncientSite()
    {
        bgm.ToAncientSite();
    }

}
