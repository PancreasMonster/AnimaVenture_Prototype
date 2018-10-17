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
  //  public GameObject col1, col2;
    public PhoneLockManager plm; 

    void Start()
        {
            //Fetch the mesh renderer component from the GameObject
            m_Renderer = GetComponent<MeshRenderer>();
            //Fetch the original color of the GameObject
            m_OriginalColor = m_Renderer.material.color;
      //  LR = GetComponent<LineRenderer>();
        }

    public void Update()
    {
        line = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plm.startSequence == true && link == false)
        {
            LR = GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<LineRenderer>();
            link = true;
        }

        if (gameObject.GetComponent<LineRenderer>() == null)
            return;

        for (int i = 0; i < LR.positionCount; i ++)
        {
            LR.SetPosition(i, plm.LRpoints[i].position);
        }
    }

    void OnMouseOver()
        {

        if (plm.startSequence == true && unselected == false)
        {
            plm.startSequence = true;
            unselected = true;

            plm.first += 1;
            plm.second += 1;
            plm.posCounter += 1;



            



            if (LR.positionCount > 0)
            {
                

                if (LR.positionCount > plm.posCount)
                {
                    plm.AddTransforms(GetComponent<Transform>());
                    LR.SetPosition(plm.second, line.origin);

                    if (gameObject.GetComponent<LineRenderer>() == null)
                        return;
                    plm.posCount += 1;

                }
            }
        }
    }

    void OnMouseExit()
     {
     // Reset the color of the GameObject back to normal
     m_Renderer.material.color = m_OriginalColor;
     }

    public void OnMouseDrag()
    {
        if (plm.startSequence == false && unselected == false)
        {
            LR = gameObject.AddComponent<LineRenderer>();
            plm.startSequence = true;
            LR.positionCount = 2;
            //plm.first -= 1;
            // plm.second -= 1;
            unselected = true;
            gameObject.tag = ("PhoneCell");
            plm.posCounter += 1;
        }

        if (gameObject.GetComponent<LineRenderer>() == null)
            return;

        if (LR.positionCount > 2)
            {
                LR.SetPosition(plm.second, line.origin);
            }
            else
            {
                LR.SetPosition(1, line.origin);
            }
            LR.positionCount = plm.posCounter;
            LR.startWidth = .2f;
            LR.endWidth = .2f;
            LR.SetPosition(0, transform.position);
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
