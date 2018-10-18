using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoinTheDots : MonoBehaviour {
    public GameObject[] dots;
    public static int dotn = 0;
    public GameObject Jigsaw;
    void Start() {

    }

    // Update is called once per frame
    public void Update() {
        if (dotn == 10)
        {
            Jigsaw.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
