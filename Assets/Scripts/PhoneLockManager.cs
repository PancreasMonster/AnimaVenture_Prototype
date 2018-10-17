using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PhoneLockManager : MonoBehaviour {

    public bool startSequence = false;
    private bool sceneTransition, checkForLR;
    public int first = 0, second = 1, posCount = 2, posCounter = 2;
    private LineRenderer LR; 
    public Button undo, finish;
    public Transform[] LRpoints; 


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

        if (startSequence && !checkForLR)
        {
            LR = GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<LineRenderer>();
            // LR.SetPosition(0, GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<Transform>().position);
            // LRpoints[0] = GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<Transform>();
            AddTransforms(GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<Transform>());
            checkForLR = true;
        }
    }



    public void NextScene ()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        sceneTransition = true;
    }

    public void AddTransforms (Transform f)
    {
        LRpoints[first] = f;
    }

    
}
