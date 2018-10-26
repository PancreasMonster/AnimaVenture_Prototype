using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour {

    public GameObject NewJigsaw;
    //public GameObject NewJigsaw;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ReloadSceene()
    {
        JoinTheDots.dotn = 0;
        Jigsaw.piecesleft = 0;
        SceneManager.LoadScene("AncientSiteScene");
    }
}
