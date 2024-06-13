using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class ProjectorMinigame : MonoBehaviour
{
    public int tapsForProjector;
    public int score;

    public float gameTime;
    public float remainingTime;

    public bool startGame;

    public TMP_Text timeText;

    public Slider slider;
    public Button projectorButton;

    void Start()
    {
        projectorButton.onClick.AddListener(OnTap);
        slider.maxValue = 10;
        slider.value = 0;
    }

    void Update()
    {
        if (startGame)
        {
            remainingTime -= Time.deltaTime;
            if (remainingTime <= 0)
            {
                EndGame();
            }
            if (score == tapsForProjector)
            {
                NextMinigame();
            }
            UpdateUI();
        }
    }

    void OnTap()
    {
        if (startGame)
        {
            score++;
            UpdateUI();
        }
    }

    void NextMinigame()
    {
        score = 0;
        SceneManager.LoadScene("Heewoo1");
    }

    void EndGame()
    {
        startGame = false;
        slider.value = 0;
        score = 0;
        timeText.text = "You Lose";
        SceneManager.LoadScene("Menu");
    }

    void UpdateUI()
    {
        timeText.text = "Time: " + Mathf.Clamp(remainingTime, 0, gameTime).ToString("F2");
        slider.value = Mathf.Clamp(score, 0, slider.maxValue);
    }
}
