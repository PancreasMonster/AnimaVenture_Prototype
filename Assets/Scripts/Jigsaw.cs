using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jigsaw : MonoBehaviour {
    public static int piecesleft = 0;
    public string sceneName;
    public GameObject finishButton;
    public GameObject restartButton;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (piecesleft == 4)
        {
            finishButton.SetActive(true);
            restartButton.SetActive(false);
        }
	}

    public void nextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
