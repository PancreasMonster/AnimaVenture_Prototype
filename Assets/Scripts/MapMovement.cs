using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMovement : MonoBehaviour {



    public bool notDragging = true;
    public float panSpeed = 4.0f;
    private Vector3 mouseOrigin;
    public bool isPanning;
    public float MIN_X, MAX_X, MIN_Y, MAX_Y;


    // Update is called once per frame
    void Update()
    {

       
        if (Input.GetMouseButtonDown(0))
        {
            //left click was pressed    
            mouseOrigin = Input.mousePosition;
            isPanning = true;
            
        }


        // on button release
        if (Input.GetMouseButtonUp(0))
        {
            isPanning = false;
        }

        //move camera while button is helf
        if (isPanning && notDragging == true)
        {
            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

            // move x and y azis but not on z axis
            Vector3 move = new Vector3(pos.x * panSpeed, pos.y * panSpeed, 0);

            transform.Translate(-move, Space.Self);
            transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, MIN_X, MAX_X), Mathf.Clamp(transform.position.y, MIN_Y, MAX_Y), -15);
            Debug.Log(pos);
            Debug.Log(move);
        }
    }

    /*
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

        if (Input.GetMouseButton(0) && notDragging == true)
        {
            Vector2 touchDeltaPosition = Input.mouseScrollDelta;
            transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
        }
        StartPosition = GetWorldPosition();

        character.transform.localScale = new Vector3(camera_GameObject.GetComponent<Camera>().orthographicSize / 5, camera_GameObject.GetComponent<Camera>().orthographicSize / 5, 1);
    
            if (Input.touchCount == 0 && isZooming)
            {
                isZooming = false;
            }
            
           if (Input.touchCount == 1)
            {
                if (!isZooming)
                {
                    
                }
            }

        if (Input.touchCount == 2 && notDragging == true)
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

