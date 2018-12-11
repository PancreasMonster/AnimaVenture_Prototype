using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PhoneLockManager : MonoBehaviour {

    public bool startSequence = false, drag = false, endAnim = false, LRmin = false;
    private bool sceneTransition, checkForLR;
    public int first = 0, second = 1, posCount = 2, posCounter = 2;
    public static LineRenderer LR; 
    public Button undo, finish;
    public Transform[] LRpoints;
    private PhoneLockScreen[] cells;
    private BoxCollider[] cellCols;
    public Color LRColour;
    private float LRHue;
    public Slider slider1;
    public Animator transitionAnim;
    private BGMusic bgm;


    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        cells = GetComponentsInChildren<PhoneLockScreen>();
        cellCols = GetComponentsInChildren<BoxCollider>();
        bgm = GameObject.FindGameObjectWithTag("BG Music").GetComponent<BGMusic>();
    }

    void Update()
    {

        Ray line = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (startSequence == true && sceneTransition == false && LRmin == true)
        {
            undo.enabled = true;
            finish.enabled = true; 
        }

        if (startSequence == false && sceneTransition == false && LRmin == false)
        {
            undo.enabled = false;
            finish.enabled = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
           // Vector3 rayPos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 0, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            if (Physics.Raycast(line.origin, Vector3.down, out hit, Mathf.Infinity))
            {
                if (hit.transform.tag == "PhoneCell" || hit.transform.tag == "SelectedCell")
                {

                    drag = true;

                }
            }
        }

        if (drag == true)
        {
            if (Input.GetMouseButtonUp(0))
            {
                drag = false;
            }
        }

        if (startSequence && !checkForLR)
        {
            LR = GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<LineRenderer>();
            // LR.SetPosition(0, GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<Transform>().position);
            // LRpoints[0] = GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<Transform>();
            AddTransforms(GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<Transform>());
            checkForLR = true;
        }
        LRHue = slider1.value;
        LRColour = Color.HSVToRGB(LRHue, 1, 1);
        slider1.image.color = Color.HSVToRGB(LRHue, 1, 1);
    }

    public void SceneChange ()
    {
        if (LR.positionCount > second)
            LR.positionCount -= LR.positionCount - second;
        bgm.ToInstructions();
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
        LRmin = false;
        posCounter = 2;
        for(int i = 0; i < LRpoints.Length; i++)
        {
            LRpoints[i] = null;
        }

        for (int i = 0; i < cells.Length; i++)
        {
            cells[i].unselected = false;
            cells[i].link = false;
            cells[i].gameObject.tag = ("Untagged");
        }
    }
    
}
