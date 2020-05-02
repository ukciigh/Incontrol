using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlArea : MonoBehaviour
{

    public float controlRange;

    public Rigidbody2D rb;

    public LayerMask whatIsControlObj;
    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit2D controlCircle = Physics2D.CircleCast(transform.position,controlRange,Vector2.zero,0,whatIsControlObj);
        if(controlCircle == true)
        {
            rb.gravityScale = 0;
            rb.constraints = RigidbodyConstraints2D.FreezePositionY |RigidbodyConstraints2D.FreezeRotation;
           
            // {
            //     rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            // }
        }


    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, controlRange);
    }
}
