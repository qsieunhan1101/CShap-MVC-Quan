using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] int speed = 10;

    [SerializeField] Transform bodyTf;

    [SerializeField] Animator anim;
    [SerializeField] string currentAnimName;

    public bool isMoving;

    Vector3 direction;

    Vector2 rot;

    // Start is called before the first frame update
    void Start()
    {

        isMoving = false;
        direction = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        if (Input.anyKeyDown)
        {
            rot.x = direction.x;
            rot.y = direction.z;
        }

        if (Vector3.Distance(direction, Vector3.zero) == 0)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }

        if (isMoving)
        {

            ChangeAnim("run");
        }
        if (!isMoving)
        {

            ChangeAnim("idle");
        }
    }
    private void Move()
    {
        GetDirection();
        SetRotation();
        rb.velocity = new Vector3(direction.x * speed, rb.velocity.y, direction.z * speed);
    }

    private void GetDirection()
    {
        direction.z = Input.GetAxisRaw("Vertical");
        direction.x = Input.GetAxisRaw("Horizontal");
    }

    private Vector3 GetRotation()
    {

        return new Vector3();
    }
    private void SetRotation()
    {

        bodyTf.rotation = Quaternion.LookRotation(new Vector3(rot.x, 0, rot.y));
    }

    private void ChangeAnim(string animName)
    {

        if (currentAnimName != animName)
        {
            anim.ResetTrigger(animName);

            currentAnimName = animName;

            anim.SetTrigger(currentAnimName);
        }

    }
}
