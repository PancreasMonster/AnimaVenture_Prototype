using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour {

    public bool fill = false;

    private void OnMouseEnter()
    {
        fill = true;
    }
}
