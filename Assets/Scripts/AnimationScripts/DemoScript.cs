using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour {

    private LineRenderer LR;
    public Animator anim;
    public Transform cursor;

	// Use this for initialization
	void Start () {
        LR = GetComponent<LineRenderer>();
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


    }
}
