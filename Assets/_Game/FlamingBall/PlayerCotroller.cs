using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCotroller : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed = 5f;


    [SerializeField] TextMeshProUGUI textScore;
    int score;

    [SerializeField] ParticleSystem particleSystem;
    [SerializeField] ParticleSystem particleEnemySystem;

    [SerializeField] bool isGameOver;

    [SerializeField] Button btnPlayAgain;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        textScore.text = $"Score: {score}";
        isGameOver = false;

        btnPlayAgain.onClick.AddListener(onPlayeAgain);
        btnPlayAgain.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (rb.velocity.magnitude < 2)
        {
            particleSystem.Stop();
        }
        else
        {
            if (!particleSystem.isPlaying)
            {
                particleSystem.Play();
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isGameOver)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

            rb.AddForce(movement * speed);

        }


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            score++;
            textScore.text = $"Score: {score}";
        }
        if (other.CompareTag("Enemy"))
        {
            isGameOver = true;
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
            particleEnemySystem.Play();
            Destroy(other.gameObject,1.5f);
            btnPlayAgain.gameObject.SetActive(true);
        }
    }

    private void onPlayeAgain()
    {
        SceneManager.LoadScene("Scene 2");
        
    }
}
