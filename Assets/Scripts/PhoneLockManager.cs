﻿using System.Collections;
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
    private PhoneLockScreen[] cells;
    private BoxCollider[] cellCols;
    public Color LRColour;
    private float r, g, b;
    public Slider slider1, slider2, slider3;


    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        cells = GetComponentsInChildren<PhoneLockScreen>();
        cellCols = GetComponentsInChildren<BoxCollider>();
    }

    void Update()
    {
        if (startSequence == true && sceneTransition == false)
        {
            undo.enabled = true;
            finish.enabled = true; 
        }

        if (startSequence == false && sceneTransition == false)
        {
            undo.enabled = false;
            finish.enabled = false;
        }

        if (startSequence && !checkForLR)
        {
            LR = GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<LineRenderer>();
            // LR.SetPosition(0, GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<Transform>().position);
            // LRpoints[0] = GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<Transform>();
            AddTransforms(GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<Transform>());
            checkForLR = true;
        }
        r = slider1.value;
        g = slider2.value;
        b = slider3.value;
        LRColour = new Color(r, g, b, 1);

    }



    public void NextScene ()
    {
        LR.positionCount -= 2;
        //SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        for (int i = 0; i < cellCols.Length; i++)
        {
            cellCols[i].enabled = false;
        }
        sceneTransition = true;
    }

    public void AddTransforms (Transform f)
    {
        LRpoints[first] = f;
    }

    public void Undo ()
    {
        startSequence = false;
        checkForLR = false;
        Destroy(LR);
        GameObject.FindGameObjectWithTag("PhoneCell").tag = ("Untagged");
        first = 0;
        second = 1;
        posCount = 2;
        posCounter = 2;
        for(int i = 0; i < LRpoints.Length; i++)
        {
            LRpoints[i] = null;
        }

        for (int i = 0; i < cells.Length; i++)
        {
            cells[i].unselected = false;
            cells[i].link = false;
        }
    }
    
}
