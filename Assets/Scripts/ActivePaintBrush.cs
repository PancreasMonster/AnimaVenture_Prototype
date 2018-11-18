using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePaintBrush : MonoBehaviour {

    public GameObject brush;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "PaintHere")
        {
            brush.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "PaintHere")
        {
            brush.SetActive(false);
        }
    }
}
