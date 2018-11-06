using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintScript : MonoBehaviour {

    public GameObject colour;
    //public Color colour;
    //public float hue;
    //public Slider slider;

	// Use this for initialization
	void Start () {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;

        //hue = slider.value;
        //colour = Color.HSVToRGB(hue, 1, 1);
        //slider.image.color = Color.HSVToRGB(hue, 1, 1);

        SpriteRenderer rend = GetComponent<SpriteRenderer>();

        rend.color = colour.GetComponent<Image>().color;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
