using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour
{
    public bool pickedup = false;
    public bool placed = false;
    //public Vector2 start;

    public GameObject Remove;
    public GameObject Create;
    // Use this for initialization
    void Start()
    {
        //start = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (pickedup == true)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }
    }

    void OnMouseDown()
    {
        pickedup = true;
    }

    void OnMouseUp()
    {
        pickedup = false;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (pickedup == false)
        {
            if (other.gameObject.name == gameObject.name)
            {
                Jigsaw.piecesleft -= 1;
                Create.SetActive(true);
                Remove.SetActive(false);
                this.gameObject.SetActive(false);
            }
            else
            {
                transform.position = transform.parent.position;
            }
        }
    }
}
