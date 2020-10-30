using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectLevel : MonoBehaviour
{
    public string changeLevel;
    public Button levelSelector;
    public Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        levelSelector.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        changeLevel = levelText.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
