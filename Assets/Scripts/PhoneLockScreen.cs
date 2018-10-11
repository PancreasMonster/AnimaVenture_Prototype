using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneLockScreen : MonoBehaviour
{
    
        //When the mouse hovers over the GameObject, it turns to this color (red)
        Color m_MouseOverColor = Color.red;

        //This stores the GameObject’s original color
        Color m_OriginalColor;

        //Get the GameObject’s mesh renderer to access the GameObject’s material and color
        MeshRenderer m_Renderer;

    bool unselected = false;
    bool link = false;
    Ray line;
    LineRenderer LR;
    public GameObject col1, col2;

    void Start()
        {
            //Fetch the mesh renderer component from the GameObject
            m_Renderer = GetComponent<MeshRenderer>();
            //Fetch the original color of the GameObject
            m_OriginalColor = m_Renderer.material.color;
        LR = GetComponent<LineRenderer>();
        }

    public void Update()
    {
        line = Camera.main.ScreenPointToRay(Input.mousePosition);
        
    }

    void OnMouseOver()
        {

        // if (unselected == false)
        // {
        //     m_Renderer.material.color = m_MouseOverColor;
        //  } else
        //  {
        
          //  LR.SetPosition(8, new Vector3(line.origin.x, transform.position.y, line.origin.z));
       // }
    }

    void OnMouseExit()
     {
     // Reset the color of the GameObject back to normal
     m_Renderer.material.color = m_OriginalColor;
     }

    public void OnMouseDrag()
    {
        if (unselected == false)
        {
          //  for (int i = 0; i < 4; i++)
         //   {
          //      LR.SetPosition(i, transform.localPosition);
           // }
            LR.SetPosition(0, transform.position);
            LR.SetPosition(1, col1.transform.position);
            LR.SetPosition(2, col2.transform.position);
            LR.SetPosition(3, new Vector3(line.origin.x, transform.position.y, line.origin.z));
            m_Renderer.material.color = m_MouseOverColor;
        }
    }

    public void OnMouseUp()
    {
        if (link == false)
        {
            //LR.SetPosition(7, transform.position);
            //LR.SetPosition(8, transform.position);
        }
    }
}
