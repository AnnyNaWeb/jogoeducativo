using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatChao : MonoBehaviour
{
   [Range(-1f,5f)]
   public float scrollSpeed = 4.0f;
   private float offset;
   private Material mat;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        offset+=(Time.deltaTime*scrollSpeed)/10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset,0));
    }
}
