using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float t = 2;
    public float force = 100;
    public Vector3 dic;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(destroy), t);
        rb.AddForce(dic*force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void destroy()
    {
        Destroy(gameObject);
    }
}
