using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Spawn : MonoBehaviour
{

    private Vector3 Min;
    private Vector3 Max;
    private float _xAxis;
    private float _yAxis;
    private Vector3 _randomPosition;

    void Start()
    {
        SetRanges();
    }
    void Update()
    {
        _xAxis = Random.Range(Min.x, Max.x);
        _yAxis = Random.Range(Min.y, Max.y);
        _randomPosition = new Vector3(_xAxis, _yAxis);
    }
    //Here put the ranges where your object will appear, or put it in the inspector.
    void SetRanges()
    {
        Min = new Vector3(2, 4); //Random value.
        Max = new Vector3(20, 40); //Another ramdon value, just for the example.
    }
    void InstantiateRandomObjects()
    {
            Instantiate(gameObject, _randomPosition, Quaternion.identity);
    }
}