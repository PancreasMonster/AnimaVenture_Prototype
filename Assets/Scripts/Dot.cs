﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour {

    public bool fill = false;
    
    public void OnMouseEnter()
    {
        if(fill == false)
        {
            fill = true;
            JoinTheDots.dotn += 1;
        }

        
    }
}
