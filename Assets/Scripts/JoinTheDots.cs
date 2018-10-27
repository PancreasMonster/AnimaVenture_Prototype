using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoinTheDots : MonoBehaviour {
    public GameObject[] dots;
    public static int dotn = 0;
    public GameObject Jigsaw;
    public GameObject[] Line;
    void Start() {

    }

    // Update is called once per frame
    public void Update() {
        if (dotn == 13)
        {
            Jigsaw.SetActive(true);
            Destroy(this.gameObject);
        }

        if(dots[0].GetComponent<Dot>().fill == true)
        {
            dots[1].SetActive(true);
        }

        if (dots[1].GetComponent<Dot>().fill == true)
        {
            dots[2].SetActive(true);
        }

        if (dots[2].GetComponent<Dot>().fill == true)
        {
            dots[3].SetActive(true);
        }

        if (dots[3].GetComponent<Dot>().fill == true)
        {
            dots[4].SetActive(true);
        }

        if (dots[4].GetComponent<Dot>().fill == true)
        {
            dots[5].SetActive(true);
        }

        if (dots[5].GetComponent<Dot>().fill == true)
        {
            dots[6].SetActive(true);
        }

        if (dots[6].GetComponent<Dot>().fill == true)
        {
            dots[7].SetActive(true);
        }

        if (dots[7].GetComponent<Dot>().fill == true)
        {
            dots[8].SetActive(true);
        }

        if (dots[8].GetComponent<Dot>().fill == true)
        {
            dots[9].SetActive(true);
        }

        if (dots[9].GetComponent<Dot>().fill == true)
        {
            dots[10].SetActive(true);
        }

        if (dots[10].GetComponent<Dot>().fill == true)
        {
            dots[11].SetActive(true);
        }

        if (dots[11].GetComponent<Dot>().fill == true)
        {
            dots[12].SetActive(true);
        }

        if (dots[0].GetComponent<Dot>().fill == true && dots[1].GetComponent<Dot>().fill == true)
        {
            Line[0].SetActive(true);
        }

        if (dots[1].GetComponent<Dot>().fill == true && dots[2].GetComponent<Dot>().fill == true)
        {
            Line[1].SetActive(true);
        }

        if (dots[2].GetComponent<Dot>().fill == true && dots[3].GetComponent<Dot>().fill == true)
        {
            Line[2].SetActive(true);
        }

        if (dots[3].GetComponent<Dot>().fill == true && dots[4].GetComponent<Dot>().fill == true)
        {
            Line[3].SetActive(true);
        }

        if (dots[4].GetComponent<Dot>().fill == true && dots[5].GetComponent<Dot>().fill == true)
        {
            Line[4].SetActive(true);
        }

        if (dots[5].GetComponent<Dot>().fill == true && dots[6].GetComponent<Dot>().fill == true)
        {
            Line[5].SetActive(true);
        }

        if (dots[6].GetComponent<Dot>().fill == true && dots[7].GetComponent<Dot>().fill == true)
        {
            Line[6].SetActive(true);
        }

        if (dots[7].GetComponent<Dot>().fill == true && dots[8].GetComponent<Dot>().fill == true)
        {
            Line[7].SetActive(true);
        }

        if (dots[8].GetComponent<Dot>().fill == true && dots[9].GetComponent<Dot>().fill == true)
        {
            Line[8].SetActive(true);
        }

        if (dots[9].GetComponent<Dot>().fill == true && dots[10].GetComponent<Dot>().fill == true)
        {
            Line[9].SetActive(true);
        }

        if (dots[10].GetComponent<Dot>().fill == true && dots[11].GetComponent<Dot>().fill == true)
        {
            Line[10].SetActive(true);
        }

        if (dots[11].GetComponent<Dot>().fill == true && dots[12].GetComponent<Dot>().fill == true)
        {
            Line[11].SetActive(true);
        }
    }
}
