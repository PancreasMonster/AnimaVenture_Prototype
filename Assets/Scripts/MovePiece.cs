using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour
{
    public bool pickedup = false;
    public bool placed = false;
    // Use this for initialization
    void Start()
    {

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
                transform.position = other.gameObject.transform.position;
                placed = true;
            }
        }
    }
}
