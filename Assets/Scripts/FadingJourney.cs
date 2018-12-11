using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadingJourney : MonoBehaviour {

    // Use this for initialization
    public float t1 = 1, t2 = 0, t3 = 0, t4 = 0;
    public ParticleSystem ps;
    public TrailRenderer tr1, tr2, tr3;
    public float fadePeriod = 5;
    private bool system1 = true, system2, system3, system4;

    // Use this for initialization
    void Start()
    {
        t1 = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!system1)
        t1 -= Time.deltaTime / fadePeriod;

        if (!system2)
            t2 -= Time.deltaTime / fadePeriod;

        if (!system3)
            t3 -= Time.deltaTime / fadePeriod;

        if (!system4)
            t4 -= Time.deltaTime / fadePeriod;


        // var col = ps.colorOverLifetime;
        //  col.enabled = true;

        // Gradient grad = new Gradient();
        // grad.SetKeys(new GradientColorKey[] { new GradientColorKey(ps.startColor, 0.0f), new GradientColorKey(ps.startColor, 1.0f) }, new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(0.0f, 1.0f) });
        // col.color = grad;
        ps.startColor = new Color(ps.startColor.r, ps.startColor.g, ps.startColor.b, t1);
        tr1.endColor = new Color(tr1.endColor.r, tr1.endColor.g, tr1.endColor.b, t2);
        tr1.startColor = new Color(tr1.startColor.r, tr1.startColor.g, tr1.startColor.b, t2);
        tr2.endColor = new Color(tr2.endColor.r, tr2.endColor.g, tr2.endColor.b, t3);
        tr2.startColor = new Color(tr2.startColor.r, tr2.startColor.g, tr2.startColor.b, t3);
        tr3.endColor = new Color(tr3.endColor.r, tr3.endColor.g, tr3.endColor.b, t4);
        tr3.startColor = new Color(tr3.startColor.r, tr3.startColor.g, tr3.startColor.b, t4);


        //trc = new

        Debug.Log(t1);
    }

    public void StartButton1 ()
    {
        t1 = 1;
        system1 = true;
        system2 = false;
        system3 = false; 
        system4 = false;
    }

    public void StartButton2()
    {
        t2 = 1;
        system1 = false;
        system2 = true;
        system3 = false;
        system4 = false;
    }

    public void StartButton3()
    {
        t3 = 1;
        system1 = false;
        system2 = false;
        system3 = true;
        system4 = false;
    }

    public void StartButton4()
    {
        t4 = 1;
        system1 = false;
        system2 = false;
        system3 = false;
        system4 = true;
    }
}
