using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgScroll : MonoBehaviour
{

     public float Scrollspeed ;
     private Material mat;
     private Vector2 offset = Vector2.zero;

    void Awake(){
        mat = GetComponent< Renderer >() .material; 
    }
    void Start()
    {
        offset =mat.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        offset.y += Scrollspeed * Time.deltaTime;   
        mat.SetTextureOffset("_MainTex",offset);
    }
}
