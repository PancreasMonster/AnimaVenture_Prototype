using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public string SceneToLoad;
    GameObject bgmh;
    BGMusic bgm;

    // Use this for initialization
    void Start () {
        bgmh = GameObject.FindGameObjectWithTag("BG Music");
        bgm = GameObject.FindGameObjectWithTag("BG Music").GetComponent<BGMusic>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Load()
    {
        bgm.ToMainMenu();
        
    }

  
}
