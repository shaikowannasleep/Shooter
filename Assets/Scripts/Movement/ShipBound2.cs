using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBound2 : MonoBehaviour
{ 
     public Camera MainCamera;
    private Vector2 screenBounds;
    private float planeWidth;
    private float planeHeight;

    // Start is called before the first frame update
    void Start()
    {
          screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        planeWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
        planeHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //extents = size of height / 2
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + planeWidth, screenBounds.x - planeWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + planeHeight, screenBounds.y - planeHeight);
        transform.position = viewPos;
    }
}
