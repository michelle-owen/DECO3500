using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topicController : MonoBehaviour
{
    public string[] easyTopics = new string[3];
    private string[] easyPresentationMethod = new string[2];
    public string[] mediumTopics = new string[3];
    private string[] mediumPresentationMethod = new string[2];
    public string[] hardTopics = new string[3];
    private string[] hardPresentationMethod = new string[2];
    public Text[] topicSectionText = new Text[2];
    public GameObject[] topicObjects = new GameObject[3];
    public levelController levelControllerScript;
    public homeController homeControllerScript;
    public int randomNumInt;
    public string levelChosen;
    public bool keyPressed;
    public GameObject recordTopicFeature;
    public string topicChosen;

    // Start is called before the first frame update
    void Start()
    {
        recordTopicFeature.SetActive(false);

        //Topics 
        easyTopics[0] = "Cats Vs Dogs";
        easyTopics[1] = "Free Education";
        easyTopics[2] = "Best Snack Foods";

        //Presentation Method
        easyPresentationMethod[0] = "Prop - Use an object closest to you";
        easyPresentationMethod[1] = "Slogan - Because you’re worth it";

        mediumTopics[0] = "Australian's Economy";
        mediumTopics[1] = "Food Wastage";
        mediumTopics[2] = "Online Tools";

        mediumPresentationMethod[0] = "Presentation - Intro, Main Points, Wrap-up";
        mediumPresentationMethod[1] = "Elevator Pitch - Intro, Aim/Goal what you hope the idea will achieve, Describe your idea, Wrap-up";

        hardTopics[0] = "Fix Climate Change";
        hardTopics[1] = "Improve Online Learning";
        hardTopics[2] = "Reduce Discrimination";

        hardPresentationMethod[0] = "Q/A - Ask the audience a question about the topic then answer their questions";
        hardPresentationMethod[1] = "Your choice";

        topicObjects[1].SetActive(false);
        topicObjects[2].SetActive(false);
    }

    public void OnClick(){
        topicObjects[2].SetActive(false);
    }

    public void ContinueButtonClick()
    {
        recordTopicFeature.SetActive(true);
    }

    public void infoContinueButton()
    {
        topicObjects[0].SetActive(false);
        topicObjects[1].SetActive(true);
        randomNumInt = Random.Range(0, 2);
    }

    public void topicSelectionContinueButton()
    {
        topicObjects[1].SetActive(false);
        topicObjects[2].SetActive(true);
        randomNumInt = Random.Range(0, 2);
    }


    // Update is called once per frame
    void Update()
    {
        //Topic is chosen based on level selected
        if (levelChosen == levelControllerScript.levelTexts[0].text)
        {
            topicSectionText[0].text = easyTopics[homeControllerScript.randomNum];
            topicChosen = topicSectionText[0].text;
            topicSectionText[1].text = easyPresentationMethod[randomNumInt];
            Debug.Log("Yay");
        }
        if (levelChosen == levelControllerScript.levelTexts[1].text)
        {
            topicSectionText[0].text = mediumTopics[homeControllerScript.randomNum];
            topicChosen = topicSectionText[0].text;
            topicSectionText[1].text = mediumPresentationMethod[randomNumInt];
        }
        if (levelChosen == levelControllerScript.levelTexts[2].text)
        {
            topicSectionText[0].text = hardTopics[homeControllerScript.randomNum];
            topicChosen = topicSectionText[0].text;
            topicSectionText[1].text = hardPresentationMethod[randomNumInt];
        }
    }
}
