﻿using System.Collections;
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
        if (bgm != null)
        bgm.ToPaintByNumbers(target);
        else
        {
            SceneManager.LoadScene("NewgrangeScene", LoadSceneMode.Single);
        }
        
    }

    public void LoadAncientSite()
    {
        bgm.ToAncientSite();
    }

}
