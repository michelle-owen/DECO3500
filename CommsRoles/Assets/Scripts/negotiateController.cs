using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class negotiateController : MonoBehaviour
{
    private string[] easyNegotiate = new string[3];
    private string[] mediumNegotiate = new string[1];
    private string[] hardNegotiate = new string[1];
    public string studentGeneralGoal = "Goal is for both sides to win and not be put at a disadvantage";
    public string sequenceString = "No, No, Yes";
    private string[] studentSpecificInfos = new string[3];
    private string[] studentSpecificOne = new string[5];
    private string clientSpecificOne;
    public Text negotiateScenario;
    public Text[] strategyTexts = new Text[10];
    public Text studentGeneralGoalText;
    public Text[] studentSpecificInfoText = new Text[5];
    public Text clientSpecificInfoText;
    public topicController topicControllerScript;
    public conflictController conflictController;
    //public Text sequenceText;
    //public homeController homeControllerScript;
    /*public GameObject own;
    public GameObject studentInfo;
    public GameObject clientInfo;
    public GameObject sequence;*/
    public GameObject[] objects = new GameObject[5];
    public string exampleScenario1;
    public string exampleScenario2;
    public string exampleScenario3;
    public string[] strategy = new string[10];
    public string hardStrategy;



    // Start is called before the first frame update
    void Start()
    {
        conflictController.objects[0].SetActive(false);

        //Negotiate Scenarios
        easyNegotiate[0] = "Well I don’t like the animal you have chosen so we will be promoting the other one as the best animal.";
        easyNegotiate[1] = "Encourage students to stop paying for their education ASAP as a way to make education free.";
        easyNegotiate[2] = "Come up with an idea to promote this snack food as a healthy alternative to other snack foods.";

        mediumNegotiate[0] = "We want you to work on this project about the topic by yourself because the others in the team are needed elsewhere";

        //hardNegotiate[0] = "We want you to work on this project about the topic by yourself because your team member doesn’t believe in climate change.";
        hardNegotiate[1] = "We will not pay you but give you experience and exposure because this is an issue that is important for you, so you are not motivated by money.";
        hardNegotiate[2] = "We will not pay you but give you experience and exposure because this is an issue that is important for you, so you are not motivated by money";

        //studentSpecificInfos[0] = "You want more time at least 3 days to come up with a great solid idea due to your busy schedule. Prepared to accept 2 days.";

        /*studentSpecificOne[0] = "You are passionate about the animal or animals you have talked about and believe they need to be promoted more so that are owned by caring and kind people.";
        studentSpecificOne[1] = "The client does not like the animal because they have never had one.";
        studentSpecificOne[2] = "Accept a small amount of promotion for the animal chosen";
        studentSpecificOne[3] = "Promote the client’s favourite animal";
        studentSpecificOne[4] = "That the animal can be mentioned but not showcased in the promotion";*/

        studentSpecificInfos[1] = "You need want to work with your team due to your busy work load and their expertise. Prepared to have at least one other person to work with";

        studentSpecificInfos[2] = "You want to be paid for the work as the rent is due soon. Prepared to take $200 or spend on a small amount of time on project for exposure.";

        //clientSpecificInfos[0] = "Your boss is expected you to have an idea as soon as possible. Willing to accept 1 to 2 days";
        //clientSpecificInfos[1] = "Your company doesn't have enough resources or money to hire a whole team. You only want 1 person but willing to accept two if they lower the price.";
        //clientSpecificInfos[2] = "Your company doesn't have enough money, however, have a lot of contacts. Willing to pay if need be less than $100";


        hardStrategy = "Use your previous experience of negotiating with the client.";

        exampleScenario1 = "Cats Vs Dogs";
        exampleScenario2 = "Free Education";
        exampleScenario3 = "Best Snack Foods";
    }

    public void OnClick()
    {
        objects[4].SetActive(false);
        conflictController.objects[0].SetActive(true);
    }

    public void infoContinueButton()
    {
        objects[0].SetActive(false);
        objects[1].SetActive(true);
    }

    public void scenarioContinueButton()
    {
        objects[1].SetActive(false);
        objects[2].SetActive(true);
    }

    public void strategyContinueButton()
    {
        objects[2].SetActive(false);
        objects[3].SetActive(true);
    }

    public void studentContinueButton()
    {
        objects[3].SetActive(false);
        objects[4].SetActive(true);
    }



    // Update is called once per frame
    void Update()
    {
        //negotiate scenario chosen based on the topic
        if (topicControllerScript.topicChosen == exampleScenario1)
        {
            negotiateScenario.text = easyNegotiate[0];
        }

        if (topicControllerScript.topicChosen == exampleScenario2)
        {
            negotiateScenario.text = easyNegotiate[1];
        }

        if (topicControllerScript.topicChosen == exampleScenario3)
        {
            negotiateScenario.text = easyNegotiate[2];
        }

        strategy[0] = "- Remain professional, calm and patient";
        strategy[1] = "- Do not become emotional, instead focus on the issue and avoid negative emotions such as anger and frustration.";
        strategy[2] = "- Do not make the negotiation personal";
        strategy[3] = "- Accept responsibility instead of blaming the other person if you did not win";
        strategy[4] = "- The other person should understand clearly what is being offered";
        strategy[5] = "- Throughout the negotiations be consistent with how objectives, goals and expectations are presented.";
        strategy[6] = "- Positive body language";
        strategy[7] = "- Be willing to compromise";
        strategy[8] = "- Find a way for both parties to win";
        strategy[9] = "- Be active and present by paying close attention to detail and ask questions";

        clientSpecificOne = "Agree, Disagree and then Agree. Your superiors wish for you to have this idea completed soon, however, you know you are being unfair and are prepared to give a bit of leeway";
        clientSpecificInfoText.text = clientSpecificOne;

        //Strategies for Negotiate Feature
        strategyTexts[0].text = strategy[0];
        strategyTexts[1].text = strategy[1];
        strategyTexts[2].text = strategy[2];
        strategyTexts[3].text = strategy[3];
        strategyTexts[4].text = strategy[4];
        strategyTexts[5].text = strategy[5];
        strategyTexts[6].text = strategy[6];
        strategyTexts[7].text = strategy[7];
        strategyTexts[8].text = strategy[8];
        strategyTexts[9].text = strategy[9];

        studentGeneralGoalText.text = studentGeneralGoal;

        studentSpecificOne[0] = "You are passionate about this topic and believe they need to be promoted more or action taken by doing small steps.";
        studentSpecificOne[1] = "The client wants action now or for the topic focused on to be different.";
        studentSpecificOne[2] = "Accept a small amount of word for the topic";
        studentSpecificOne[3] = "Allow the change of topic to be added to the preexisting idea or small action taken to work towards the task";
        studentSpecificOne[4] = "Allow some changes, however, stay true to what you want";


        //Negotiate Scenario Context Information
        studentSpecificInfoText[0].text = studentSpecificOne[0];
        studentSpecificInfoText[1].text = studentSpecificOne[1];
        studentSpecificInfoText[2].text = studentSpecificOne[2];
        studentSpecificInfoText[3].text = studentSpecificOne[3];
        studentSpecificInfoText[4].text = studentSpecificOne[4];
    }
}
