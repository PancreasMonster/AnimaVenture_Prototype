using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jigsaw : MonoBehaviour {
    public static int piecesleft = 0;
    public string sceneName;
    public GameObject JTD;
    public GameObject Jig;
    public GameObject finishButton;
    public GameObject restartButton;
    public GameObject particle;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (piecesleft == 4)
        {
            StartCoroutine(Next());
        }
	}

    public void nextScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator Next()
    {
        particle.SetActive(true);
        yield return new WaitForSeconds(2);
        JTD.SetActive(true);
        Jig.SetActive(false);
    }
}
