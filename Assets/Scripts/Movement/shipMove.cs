using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMove : MonoBehaviour
{
   
    public float planeSpeed;
    private Rigidbody2D planebody;
    private float minX,minY,maxX,maxY;
   
void Awake(){
    planebody = GetComponent<Rigidbody2D>();
}

    void Start()
    {
         planebody = GetComponent<Rigidbody2D>();
         }

    void Update(){
        PlaneMoveMent();
    }

void PlaneMoveMent(){
    float xAxis = Input.GetAxisRaw("Horizontal") * planeSpeed;
    float yAxis = Input.GetAxisRaw("Vertical") * planeSpeed;
    planebody.velocity = new Vector2 (xAxis, yAxis);
}

}
