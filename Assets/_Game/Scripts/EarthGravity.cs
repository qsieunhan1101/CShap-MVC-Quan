using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthGravity : MonoBehaviour
{
    public float gravity = -12;


    public void attract(Transform playerTranform)
    {
        Vector3 gravityUp = (playerTranform.position - transform.position).normalized;
        Vector3 localUp = playerTranform.up;

        playerTranform.GetComponent<Rigidbody>().AddForce(gravityUp* gravity);

        Quaternion targetRotation = Quaternion.FromToRotation(localUp, gravityUp) * playerTranform.rotation;
        playerTranform.rotation = Quaternion.Slerp(playerTranform.rotation, targetRotation, 50f * Time.deltaTime);
    }
}
