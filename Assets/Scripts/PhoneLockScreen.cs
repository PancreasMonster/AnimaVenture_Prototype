﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneLockScreen : MonoBehaviour
{
    
        //When the mouse hovers over the GameObject, it turns to this color (red)
        Color m_MouseOverColor = Color.red;

        //This stores the GameObject’s original color
        Color m_OriginalColor;

        //Get the GameObject’s mesh renderer to access the GameObject’s material and color
     //   MeshRenderer m_Renderer;

    public bool unselected = false;
    public bool link = false, linking = true;
    Ray line;
    LineRenderer LR;
    public PhoneLockManager plm;
    private GameObject aud;
    Shader shader1;
    Transform tran;
    ParticleSystem ps;
    //private bool colourChanger;

    void Start()
        {
            //Fetch the mesh renderer component from the GameObject
           // m_Renderer = GetComponent<MeshRenderer>();
            //Fetch the original color of the GameObject
          //  m_OriginalColor = m_Renderer.material.color;
        //  LR = GetComponent<LineRenderer>();
        aud = GameObject.FindGameObjectWithTag("RelaxPercussion");
        shader1 = Shader.Find("UI/Default");
        tran = GetComponentInParent<Transform>();
        ps = GetComponent<ParticleSystem>();
        }

    public void Update()
    {
        line = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plm.startSequence == true && link == false)
        {
            LR = GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<LineRenderer>();
            link = true;
        }

       

    



        if (gameObject.GetComponent<LineRenderer>() != null)
        {
            
            if(Input.GetMouseButtonUp(0) && linking == true)
            {
                LR.positionCount -= 2;
                linking = false; 
            }

            LR.material.color = plm.LRColour;
            LR.material.shader = shader1;
            LR.colorGradient.mode = GradientMode.Fixed;

            for (int i = 0; i < LR.positionCount; i++)
            {
                LR.SetPosition(i, plm.LRpoints[i].position);
            }

            if (LR.positionCount > 1) {
                plm.LRmin = true;
            } else
            {
                plm.LRmin = false;
            }
        }
    }

    void OnMouseOver()
    {

        if (plm.drag == true && plm.endAnim == true) { 
        if (plm.startSequence == true && unselected == false)
        {
            plm.startSequence = true;
            unselected = true;
            gameObject.tag = ("SelectedCell");
            plm.first += 1;
            plm.second += 1;
            plm.posCounter += 1;

            //GameObject clone = Instantiate(aud, transform.position, Quaternion.identity);
            // Destroy(clone, 2);

            var col = ps.colorOverLifetime;
            col.enabled = true;

            Gradient grad = new Gradient();
            grad.SetKeys(new GradientColorKey[] { new GradientColorKey(plm.LRColour, 0.0f), new GradientColorKey(plm.LRColour, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
            col.color = grad;
            ps.Play();
            StartCoroutine(StopPS());



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
    }

    void OnMouseExit()
     {
    // m_Renderer.material.color = m_OriginalColor;
     }

    public void OnMouseDrag()
    {
        if (plm.startSequence == false && unselected == false && plm.endAnim == true)
        {
            LR = gameObject.AddComponent<LineRenderer>();
            plm.startSequence = true;
            LR.positionCount = 2;
            unselected = true;
            gameObject.tag = ("PhoneCell");
            plm.posCounter += 1;
            plm.drag = true;
            var col = ps.colorOverLifetime;
            col.enabled = true;

            Gradient grad = new Gradient();
            grad.SetKeys(new GradientColorKey[] { new GradientColorKey(plm.LRColour, 0.0f), new GradientColorKey(plm.LRColour, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
            col.color = grad;
            ps.Play();
            StartCoroutine(StopPS());

        }

        if (gameObject.GetComponent<LineRenderer>() != null)
        {

            linking = true;

            if (LR.positionCount > 2)
            {
                LR.SetPosition(plm.second, line.origin);
            }
            else
            {
                LR.SetPosition(1, line.origin);
            }
            LR.positionCount = plm.posCounter;
            // LR.startColor = (Color.blue);
            //  LR.endColor = (Color.blue);
            LR.startWidth = .2f; //tran.localScale.x / 5;
            LR.endWidth = .2f; // tran.localScale.x / 5;
            LR.numCornerVertices = 1;
            LR.alignment = LineAlignment.TransformZ;
            LR.SetPosition(0, transform.position);
            LR.sortingOrder = -1;
        }

        if (gameObject.GetComponent<LineRenderer>() == null && unselected == true)
        {

            linking = true;

            LineRenderer mainLR = GameObject.FindGameObjectWithTag("PhoneCell").GetComponent<LineRenderer>();

            if (LR.positionCount > 2)
            {
                mainLR.SetPosition(plm.second, line.origin);
            }
            else
            {
                mainLR.SetPosition(1, line.origin);
            }
            mainLR.positionCount = plm.posCounter;
            // mainLR.startColor = (Color.blue);
            //  mainLR.endColor = (Color.blue);
            mainLR.startWidth = .2f; //tran.localScale.x / 5;
            mainLR.endWidth = .2f; // tran.localScale.x / 5;
            mainLR.numCornerVertices = 1;
            mainLR.alignment = LineAlignment.TransformZ;
            mainLR.SetPosition(0, transform.position);
            mainLR.sortingOrder = -1;
        }
    }

   

    public void OnMouseUp()
    {
        if (link == false)
        {
            
        }
    }

    IEnumerator StopPS()
    {
        yield return new WaitForSeconds(Time.deltaTime);
        ps.Stop();
    }
}
