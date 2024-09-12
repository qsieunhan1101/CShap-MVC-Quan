using UnityEngine;

public class BackgroundSound : MonoBehaviour
{

    private static BackgroundSound instance = null;

    public static BackgroundSound Instance
    {
        get { return instance; } 
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
