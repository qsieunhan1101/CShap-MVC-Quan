using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI textTest;
    [SerializeField] Button btnTest;
    [SerializeField] Button btnLink;
    [SerializeField] List<string> strings;
    [SerializeField] List<string> links;
    // Start is called before the first frame update
    void Start()
    {
        btnTest.onClick.AddListener(onBtnTest);
        btnLink.onClick.AddListener(onBtnLink);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
    private void onBtnTest()
    {
        textTest.text = strings[Random.Range(0,strings.Count)];
    }
    private void onBtnLink()
    {
        Application.OpenURL(links[Random.Range(0, links.Count)]);
    }
}
