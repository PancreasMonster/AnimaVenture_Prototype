using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour {

    
    public float dragSpeed = 2;
    private Vector3 dragOrigin;

    public bool notDragging = true;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(0)) return;

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(pos.x * dragSpeed, 0, pos.y * dragSpeed);

        transform.Translate(move, Space.World);
    }

    
    /*
    public float speed = 1;
    
    private Vector3 posOrg;



    private void Start()
    {
        posOrg = camera_GameObject.GetComponent<Camera>().WorldToViewportPoint(transform.position);
    }




    public GameObject camera_GameObject;
    public GameObject character;
    public float panSpeedX, panSpeedY;

    Vector2 StartPosition;
    Vector2 DragStartPosition;
    Vector2 DragNewPosition;
    Vector2 Finger0Position;
    float DistanceBetweenFingers;
    bool isZooming;

    // Update is called once per frame
    void Update()
    {

        character.transform.localScale = new Vector3(camera_GameObject.GetComponent<Camera>().orthographicSize / 5, camera_GameObject.GetComponent<Camera>().orthographicSize / 5, 1);
    
            if (Input.touchCount == 0 && isZooming)
            {
                isZooming = false;
            }

            if (Input.touchCount == 1)
            {
                if (!isZooming)
                {
                    if (Input.GetTouch(0).phase == TouchPhase.Moved && notDragging == true)
                    {
                        Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                        transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
                    }
                    StartPosition = GetWorldPosition();
                }
            }
            else if (Input.touchCount == 2 && notDragging == true)
            {
                if (Input.GetTouch(1).phase == TouchPhase.Moved)
                {
                    isZooming = true;

                    DragNewPosition = GetWorldPositionOfFinger(1);
                    Vector2 PositionDifference = DragNewPosition - DragStartPosition;

                if (Vector2.Distance(DragNewPosition, Finger0Position) < DistanceBetweenFingers)
                {
                    camera_GameObject.GetComponent<Camera>().orthographicSize += (PositionDifference.magnitude);
                   // character.transform.position = Camera.main.ViewportToWorldPoint(posOrg);
                }

                if (Vector2.Distance(DragNewPosition, Finger0Position) >= DistanceBetweenFingers)
                {
                    camera_GameObject.GetComponent<Camera>().orthographicSize -= (PositionDifference.magnitude);
                    //character.transform.position = Camera.main.ViewportToWorldPoint(posOrg);
                }
                DistanceBetweenFingers = Vector2.Distance(DragNewPosition, Finger0Position);
                }
                DragStartPosition = GetWorldPositionOfFinger(1);
                Finger0Position = GetWorldPositionOfFinger(0);
            }
        }

        Vector2 GetWorldPosition()
        {
            return camera_GameObject.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
        }

        Vector2 GetWorldPositionOfFinger(int FingerIndex)
        {
            return camera_GameObject.GetComponent<Camera>().ScreenToWorldPoint(Input.GetTouch(FingerIndex).position);
        } */
    
}

