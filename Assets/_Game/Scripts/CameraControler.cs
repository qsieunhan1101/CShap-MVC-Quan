using UnityEngine;

public class CameraControler : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothTime;
    [SerializeField] public GameObject target;
    private Vector3 current = Vector3.zero;




    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {

            Vector3 targetPosition = target.transform.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref current, smoothTime);
            transform.LookAt(target.transform);
        }
    }
}
