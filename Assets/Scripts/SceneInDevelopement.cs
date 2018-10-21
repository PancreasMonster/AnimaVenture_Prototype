using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneInDevelopement : MonoBehaviour {
    public Text textBox;
    public string textToShow;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseOver()
    {
        textBox.text = textToShow;
    }

    void OnMouseExit()
    {
        textBox.text = "";
    }
}
