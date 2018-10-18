using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour {

    public bool fill = false;
    
    public void OnMouseEnter()
    {
        JoinTheDots.dotn += 1;
        Destroy(this);
    }
}
