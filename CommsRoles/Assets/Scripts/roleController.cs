using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class roleController : MonoBehaviour
{
    public Text numberParticipants;
    public Canvas roleCanvas;
    private string currentParticipantNumString;
    public int currentParticipantNum;
    public Text[] participantsNames = new Text[6];
    public string[] participantsNameStrings = new string[6];
    public string client;
    public string leader;
    private int randomNum;
    private int leaderNum;
    public GameObject assignRoleButton;
    public GameObject roleScene;
    public string stringToEdit;

    // Start is called before the first frame update
    void Start()
    {
        roleCanvas.GetComponent<Canvas>().enabled = false;
        roleScene.SetActive(false);
        assignRoleButton.SetActive(false);
    }

    //Choses a random client 
    public void assignRandomRole()
    {
        randomNum = Random.Range(0, currentParticipantNum);
        client = participantsNameStrings[randomNum];
        
        leaderNum = leaderRole(randomNum);
        leader = participantsNameStrings[leaderNum];

        roleCanvas.GetComponent<Canvas>().enabled = false;
        roleScene.SetActive(true);
        assignRoleButton.SetActive(false);
    }

    //Chooses a random leader
    public int leaderRole(int randomNum)
    {
        int leaderNum = 0;
        leaderNum = Random.Range(0, currentParticipantNum);
        while (leaderNum == randomNum)
        {
            leaderNum = Random.Range(0, currentParticipantNum);
        }
        return leaderNum;
    }

    // Update is called once per frame
    void Update()
    {
        //Participants numbers are stored in an array
        currentParticipantNum = int.Parse(numberParticipants.text);
        for (int i = 0; i < currentParticipantNum; i++)
        {
            participantsNameStrings[i] = participantsNames[i].text.ToString();
        }
    }
}
