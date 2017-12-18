using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderTIF : MonoBehaviour {

    public Texture2D tifFile;
    //use TextureImporter ?

	// Use this for initialization
	void Start () {
        int x = 1;
        int y = 1;
        Color color = tifFile.GetPixel(x,y);
        print(color);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
