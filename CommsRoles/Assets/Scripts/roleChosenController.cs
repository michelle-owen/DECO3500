using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roleChosenController : MonoBehaviour
{
    public Text leader;
    public Text client;
    public roleController roleControllerScript;
    public GameObject Home;
    public GameObject own;

    // Start is called before the first frame update
    void Start()
    {
        Home.SetActive(false);
    }

    public void OnClick()
    {
        own.SetActive(false);
        Home.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        leader.text = roleControllerScript.leader;
        client.text = roleControllerScript.client;
    }
}
