using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlObjCtrller : MonoBehaviour
{
    //  private float moveCtrlAxisX = 0.0f;
    //  private float moveCtrlAxisY = 0.0f;

     private float moveSpeed = 5f;

     private Vector2 controlmoveVelocity;



    private Rigidbody2D ControlObjRb;
    
    void Start()
    {
        ControlObjRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("ControlX"), Input.GetAxisRaw("ControlY")); 
        controlmoveVelocity = moveInput * moveSpeed;
    }

     void FixedUpdate() 
    {
        ControlObjRb.MovePosition(ControlObjRb.position + controlmoveVelocity * Time.fixedDeltaTime);
    }
}
