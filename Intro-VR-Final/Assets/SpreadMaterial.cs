using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreadMaterial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numberOfSegments = 15; 
        MeshRenderer mr = roadTile.GetComponent(); 
        mr.material.SetTextureScale("_MainTex", new Vector2(1f / numberOfSegments, 1f / numberOfSegments)); mr.material.SetTextureOffset("_MainTex", new Vector2(x 1f / numberOfSegments, y 1f / numberOfSegments)); 
        mr.material.mainTexture = texture;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
