using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PhoneLockManager : MonoBehaviour {

    public bool startSequence = false, sceneTransition;
    public int first = 0, second = 1, posCount = 2, posCounter = 2;
    public Button undo, finish;


    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (startSequence == true && sceneTransition == false)
        {
            undo.enabled = true;
            finish.enabled = true; 
        }
    }



    public void NextScene ()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        sceneTransition = true;
    }

    
}
