using UnityEngine;
using UnityEngine.AI;

public class CubeAI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    public Bullet bullet;
    public Transform bulletPoint;

    public float bulletSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickToMoveAI();

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
            Debug.Log("SHOOOOOOOOOOOT");
        }
    }


    private void clickToMoveAI()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit,100))
        {
            if (hit.transform.CompareTag("Stage"))
            {
                agent.SetDestination(hit.point);
            }
        }
    }

    private void shoot()
    {
        Bullet b = GameObject.Instantiate(bullet);
        b.transform.position = bulletPoint.position;
        Vector3 dic = (bulletPoint.position - transform.position).normalized;
        
        b.dic = dic;
    }
}
