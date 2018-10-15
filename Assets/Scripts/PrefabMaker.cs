using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PrefabMaker : MonoBehaviour {

    public Transform t;

    void Start()
    {
        DoCreateSimplePrefab();   
    }

    [MenuItem("My Project/Create Simple Prefab")]
    static void DoCreateSimplePrefab()
    {
        
            Object prefab = PrefabUtility.CreateEmptyPrefab("Assets/Temporary/avatar.prefab");
            PrefabUtility.ReplacePrefab(t.gameObject, prefab, ReplacePrefabOptions.ConnectToPrefab);
        
    }
}
