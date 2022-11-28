using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         var worldheight = Camera.main.orthographicSize * 2f;

        var worldwidth = worldheight * Screen.width / Screen.height ;

     transform.localScale = new Vector3(worldwidth, worldheight,0f);  
    }
  
}
