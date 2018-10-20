using UnityEngine.SceneManagement;
using UnityEngine;



public class Colour_By_Numbers : MonoBehaviour {

    public int CurrentColour = 0;
    public int piecesCompleted, maxPieces = 32;
    public GameObject finishScene; 
	// Use this for initialization
	void Start () {
		
	}

    public void ChangeColour (int ColourPalette)
    {
        CurrentColour = ColourPalette;
        Debug.Log(ColourPalette);
    }

    public void FillInColour (GameObject GO)
    {
        if (Input.GetMouseButtonDown(0))
        {
            GO.SetActive(false);
        }
    }

    /*public void OnMouseDown()
    {
        if (gameObject.tag == "Button1")
        {
            ColourPalette = 1;
            Debug.Log("ColourPalette1");
        }
        else if (gameObject.tag == "Button2")
        {
            ColourPalette = 2;
            Debug.Log("ColourPalette2");
        }
        else if (gameObject.tag == "Button3")
        {
            ColourPalette = 3;
            Debug.Log("ColourPalette3");
        }
        else if (gameObject.tag == "Button4")
        {
            ColourPalette = 4;
            Debug.Log("ColourPalette4");
        }
        else if (gameObject.tag == "Button5")
        {
            ColourPalette = 5;
            Debug.Log("ColourPalette5");
        }
        else if (gameObject.tag == "Button6")
        {
            ColourPalette = 6;
            Debug.Log("ColourPalette6");
        }
        else if (gameObject.tag == "Button7")
        {
            ColourPalette = 7;
            Debug.Log("ColourPalette7");
        }
        else if (gameObject.tag == "Button8")
        {
            ColourPalette = 8;
            Debug.Log("ColourPalette8");
        }
        else if (gameObject.tag == "Button9")
        {
            ColourPalette = 9;
            Debug.Log("ColourPalette9");
        }
    }*/

    // Update is called once per frame
    void Update () {
        if (piecesCompleted >= maxPieces)
        {
            finishScene.SetActive(true);
        }
    }

    public void ChangeScene ()
    {
        SceneManager.LoadScene("AncientSiteScene", LoadSceneMode.Single);
    }
}
