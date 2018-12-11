using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class LOADSCENEWORKING : MonoBehaviour {

    public void LoadTheNextScene ( int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
