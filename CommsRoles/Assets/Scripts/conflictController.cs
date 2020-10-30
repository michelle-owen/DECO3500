using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conflictController : MonoBehaviour
{
    private string[] easyConflict = new string[1];
    private string[] mediumConflict = new string[1];
    private string[] hardConflict = new string[1];
    public string sequenceString = "No, No, Yes";
    public Text strategyText;
    public string strategy;
    public string scenarioChosen;
    public Text scenario;
    public topicController topicControllerScript;
    public GameObject home;
    public GameObject[] objects = new GameObject[4];

    // Start is called before the first frame update
    void Start()
    {
        //Scenarios for the conflict levels
        easyConflict[0] = "I wanted you to give me a personal experience about the topic";
        mediumConflict[0] = "I don't want your team members working on this project";
        hardConflict[0] = "I don't think you are qualified to be team leader";
    }

    //home button when clicked will take the user home
    public void homeButton()
    {
        objects[2].SetActive(false);
        home.SetActive(true);
    }

    //contnue button when clicked will take the user to the scenario page
    public void dataClick()
    {
        objects[0].SetActive(false);
        objects[1].SetActive(true);
    }

    //contnue button when clicked will take the user to the strategy page
    public void scenarioClick()
    {
        objects[1].SetActive(false);
        objects[2].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        strategy = "Keep calm. Be honest and fair by assessing the problem. Respond in a professional manner. Be clear about what your decision is and stick to it. When conflict is done move on";
        strategyText.text = strategy; ;

        scenarioChosen = "I wanted you to give me a personal experience about the topic with examples in the last meeting";
        scenario.text = scenarioChosen;
    }
}
