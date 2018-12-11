using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class LOADSCENEWORKING : MonoBehaviour {

    BGMusic bgm;

    void Start()
    {
        bgm = GameObject.FindGameObjectWithTag("BG Music").GetComponent<BGMusic>();
    }


    public void sceneTransition()
    {
        bgm.ToWorldScene();
    }
}
