using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public List<Material> materials;
    public ParticleSystem partical;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            testRayCast();

        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            partical.Play();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            partical.Stop(); ;
        }
    }

    public void testRayCast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit,100))
        {
            Debug.Log(hit.transform.name);
            MeshRenderer meshObj = hit.transform.GetComponent<MeshRenderer>();
            if (meshObj != null)
            {
                meshObj.material = materials[Random.Range(0,materials.Count)];

            }
        }
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
