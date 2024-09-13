using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    public EarthGravity attractorPlanet;
    private Transform playerTransform;

    public Rigidbody rb;

    void Start()
    {
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezeRotation;

        playerTransform = transform;
    }
    private void FixedUpdate()
    {
        if (attractorPlanet)
        {
            attractorPlanet.attract(playerTransform);
        }
    }

}
