using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeController : MonoBehaviour
{
    public GameObject own;
    public GameObject[] features = new GameObject[5];
    public int randomNum;
    public int negotiateNum;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < features.Length; i++)
        {
            features[i].SetActive(false);
        }
    }

    public void showTopicPage()
    {
        features[0].SetActive(true);
        hideHomePage();
        pickRandomNum();
    }

    public void showRecordPage()
    {
        features[1].SetActive(true);
        hideHomePage();
    }

    public void showNegotiatePage()
    {
        features[2].SetActive(true);
        hideHomePage();
        pickNegotiateNum();
    }

    public void showConflictPage()
    {
        features[3].SetActive(true);
        hideHomePage();
    }

    public void showFeedbackPage()
    {
        features[4].SetActive(true);
        hideHomePage();
    }

    public void pickRandomNum()
    {
        randomNum = Random.Range(0, 3);
    }

    public void pickNegotiateNum()
    {
        negotiateNum = Random.Range(0, 2);
    }

    public void hideHomePage()
    {
        own.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
