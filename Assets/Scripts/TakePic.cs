using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePic : MonoBehaviour {

    bool takeshot = false;
    int resWidth = 490;
    int resHeight = 380;
    public Camera myCam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(takeshot == true)
        {
            RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
            myCam.targetTexture = rt;
            Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGBA32, false);
            myCam.Render();
            RenderTexture.active = rt;
            screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
            myCam.targetTexture = null;
            RenderTexture.active = null;
            Destroy(rt);
            byte[] bytes = screenShot.EncodeToPNG();
            string filename = ScreenShotName("Picture");
            System.IO.File.WriteAllBytes(filename, bytes);
            takeshot = false;
        }

	}

    public static string ScreenShotName(string s)
    {
        return string.Format("{0}/drawings/screen_{1}x{2}.png",
                             Application.dataPath,
                             s,
                             System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
    }

    public void TakeShot()
    {
        takeshot = true;
    }

}
