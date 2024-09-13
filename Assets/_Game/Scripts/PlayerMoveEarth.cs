using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveEarth : MonoBehaviour
{

    public Rigidbody rb;
    private Vector3 moveDirection;

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0 , Input.GetAxisRaw("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + transform.TransformDirection(moveDirection));
    }
}
