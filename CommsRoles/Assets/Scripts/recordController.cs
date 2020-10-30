using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recordController : MonoBehaviour
{
    public topicController topicControllerScript;
    public Text topicScenario;
    public Text topicMethod;
    public GameObject[] topicRecordObjects = new GameObject[3];
    public GameObject home;
    public GameObject negotitateInfoObject;

    // Start is called before the first frame update
    void Start()
    {
        topicRecordObjects[1].SetActive(false);
        topicRecordObjects[2].SetActive(false);
        negotitateInfoObject.SetActive(false);
    }

    public void stopRecordingButton()
    {
        topicRecordObjects[1].SetActive(false);
        topicRecordObjects[2].SetActive(true);
    }

    public void homeButtonClicked()
    {
        topicRecordObjects[2].SetActive(false);
        home.SetActive(true);
    }

    public void continueButtonClicked()
    {
        topicRecordObjects[2].SetActive(false);
        negotitateInfoObject.SetActive(true);
    }

    public void topicContinueButton()
    {
        topicRecordObjects[0].SetActive(false);
        topicRecordObjects[1].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        topicScenario.text = topicControllerScript.topicSectionText[0].text;
        topicMethod.text = topicControllerScript.topicSectionText[1].text;
    }
}
