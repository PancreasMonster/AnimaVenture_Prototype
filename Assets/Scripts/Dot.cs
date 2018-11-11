using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour {

    public bool fill = false;

    void Start()
    {
        this.gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.position);
        this.gameObject.GetComponent<LineRenderer>().SetPosition(1, transform.position);
    }

    public void OnMouseEnter()
    {
        if(fill == false)
        {
            if (Input.GetMouseButton(0))
            {
                fill = true;
                JoinTheDots.dotn += 1;
            }
        }

        
    }

    public void OnMouseDown()
    {
        if (fill == false)
        {
            if (Input.GetMouseButton(0))
            {
                fill = true;
                JoinTheDots.dotn += 1;
            }
        }


    }
}
