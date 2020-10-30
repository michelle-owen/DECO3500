using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    int stage, correct, wait = 0;
    float timer, seconds, minutes;

    public Button startButton;
    public Button againButton;
    public Text timeText;

    public CanvasGroup sButton;
    public CanvasGroup aButton;
    public CanvasGroup end;
    public CanvasGroup prompt;
    public CanvasGroup nextPrompt;
    public CanvasGroup timeCounter;

    void Start()
    {
        sButton.alpha = 1;
        aButton.alpha = 0;
        end.alpha = 0;
        prompt.alpha = 0;
        nextPrompt.alpha = 0;
        timeCounter.alpha = 0;
        timer = 0;
        stage = 0;

        Button btn = startButton.GetComponent<Button>();
		btn.onClick.AddListener(StartPlaying);

        Button btn2 = againButton.GetComponent<Button>();
		btn2.onClick.AddListener(StartPlaying);
    }

    void Update()
    {
        if (stage != 5) {
            stopWatchCalc();
        }
        switch (stage)
        {
            case 1:
                if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.O) || Input.GetKeyDown(KeyCode.M) ||
                Input.GetKeyDown(KeyCode.Z)) {
                    correct += 1;
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.P) ||
                Input.GetKeyDown(KeyCode.N)) {
                    Debug.Log("Pressed!");
                    correct += 1;
                }
                break;
            case 3:
                if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.M) ||
                Input.GetKeyDown(KeyCode.P)) {
                    Debug.Log("Pressed!");
                    correct += 1;
                }
                break;
            case 4:
                if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.O) || Input.GetKeyDown(KeyCode.N) ||
                Input.GetKeyDown(KeyCode.X)) {
                    Debug.Log("Pressed!");
                    correct += 1;
                }
                break;
        }

        if (correct >= 4)
        {
            stage += 1;
            prompt.alpha = 1;
            nextPrompt.alpha = 0;
            correct = 0;
        }

        if (stage >= 5)
        {
            end.alpha = 1;
            aButton.alpha = 1;
            prompt.alpha = 0;
            nextPrompt.alpha = 0;
        }

        if (prompt.alpha == 1) {
            wait += 1;
        }

        if (wait == 300) {
            prompt.alpha = 0;
            nextPrompt.alpha = 1;
        }
    }

    void StartPlaying() {
        sButton.alpha = 0;
        nextPrompt.alpha = 1;
        timeText.text = "00:00";
        timer = Time.deltaTime;
        timeCounter.alpha = 1;
        stage = 1;

        aButton.alpha = 0;
        end.alpha = 0;
    }

    void stopWatchCalc() {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        minutes = (int)(timer / 60);

        timeText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
