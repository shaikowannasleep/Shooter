using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMoveUpdate : MonoBehaviour
{

    [SerializeField] private float shipSpeed;
    [SerializeField] private float shipTurnSpeed;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody2D mybody;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        this.ShipMov();
    }

    protected virtual void ShipMov()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.parent.Translate(Vector2.up * Time.deltaTime * shipSpeed * verticalInput);
        transform.parent.Translate(Vector2.right * Time.deltaTime * shipTurnSpeed * horizontalInput);
    }

}
