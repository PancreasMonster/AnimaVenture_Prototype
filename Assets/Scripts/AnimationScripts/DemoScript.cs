using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour {

    private PhoneLockScreen pls;
    private LineRenderer LR;
    private DemoScript ds;
    public Animator anim;
    public Transform cursor;
    public GameObject cursorMain, panel;
    public PhoneLockManager plm;

    // Use this for initialization
    void Start () {
        pls = GetComponent<PhoneLockScreen>();
        LR = GetComponent<LineRenderer>();
        ds = GetComponent<DemoScript>();
        StartCoroutine(DemoScene());
        LR.startWidth = .2f; //tran.localScale.x / 5;
        LR.endWidth = .2f; // tran.localScale.x / 5;
        LR.numCornerVertices = 1;
        LR.alignment = LineAlignment.TransformZ;
       // LR.SetPosition(0, transform.position);
        LR.sortingOrder = -1;
    }
	
	// Update is called once per frame
	void Update () {
        LR.SetPosition(0, transform.position);
        LR.SetPosition(1, cursor.position);
	}

    IEnumerator DemoScene()
    {
        yield return new WaitForSeconds(2);
        anim.SetBool("Start", true);
        yield return new WaitForSeconds(2);
        pls.enabled = true;
        Destroy(LR);
        Destroy(cursorMain);
        Destroy(panel);
        plm.endAnim = true;
        yield return new WaitForSeconds(Time.deltaTime);
        plm.Undo();
        yield return new WaitForSeconds(Time.deltaTime);
        Destroy(ds);
    }
}
