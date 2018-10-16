using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour {

    public bool fill = false;

    private void OnMouseDown()
    {
        fill = true;
    }

    private void OnMouseDrag()
    {
        fill = true;
    }
}
