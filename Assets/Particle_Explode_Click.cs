using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Explode_Click : MonoBehaviour {

    public GameObject StarParticles;
    private Vector3 mouseOrigin;

    // Use this for initialization
    void Start () {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        mouseOrigin = Input.mousePosition;
        Destroy(this.gameObject);
        Instantiate(StarParticles);
    }
}
