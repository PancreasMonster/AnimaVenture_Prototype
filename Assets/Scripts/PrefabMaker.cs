using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PrefabMaker : MonoBehaviour {

    public Transform t;
    private GameObject avatar;

    void Start()
    {
        DoCreateSimplePrefab();
    }

    //[MenuItem("My Project/Create Simple Prefab")]
    void DoCreateSimplePrefab()
    {
        //Transform[] transforms = Selection.transforms;
        //foreach (Transform t in transforms)
       // {
            Object prefab = PrefabUtility.CreateEmptyPrefab("Assets/Temporary/" + t.gameObject.name + ".prefab");
            PrefabUtility.ReplacePrefab(t.gameObject, avatar, ReplacePrefabOptions.ConnectToPrefab);
       // }
    }
}

