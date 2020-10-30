using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelController : MonoBehaviour
{
    public Button[] levelButtons = new Button[3];
    public Text[] levelTexts = new Text[3];
    public roleController roleControllerScript;
    public GameObject levelPageObject;
    public topicController topicControllerScript;
    public int levelNum;

    // Start is called before the first frame update
    void Start()
    {
        levelButtons[0].onClick.AddListener(OnEasyClick);
        levelButtons[1].onClick.AddListener(OnMediumClick);
        levelButtons[2].onClick.AddListener(OnHardClick);
        levelNum = 0;
    }

    public void OnEasyClick()
    {
        levelNum = 1;
        levelButtonClicked();
    }

    public void OnMediumClick()
    {
        levelNum = 2;
        levelButtonClicked();
    }

    public void OnHardClick()
    {
        levelNum = 3;
        levelButtonClicked();
    }

    public void levelButtonClicked()
    {
        topicControllerScript.levelChosen = levelTexts[levelNum - 1].text;
        enableRoleSelectionPage();
    }

    //When the button is clicked the user will go to role selection page
    public void enableRoleSelectionPage()
    {
        roleControllerScript.roleCanvas.GetComponent<Canvas>().enabled = true;
        roleControllerScript.assignRoleButton.SetActive(true);
        levelPageObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
