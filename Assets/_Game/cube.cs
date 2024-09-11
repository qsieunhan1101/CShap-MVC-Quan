using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void cubeTest()
    {
        
        Debug.Log("1215315");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision with" + collision.gameObject.name);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision with" + other.gameObject.name);

    }
}
