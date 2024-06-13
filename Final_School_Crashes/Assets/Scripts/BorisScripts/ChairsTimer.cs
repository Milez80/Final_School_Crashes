using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ChairsTimer : MonoBehaviour
{
    public float gameTime;
    public float remainingTime;

    public TMP_Text timeText;

    private bool timeIsRunning = false;
    public static ChairsTimer Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        timeIsRunning = true;
    }

   
    void Update()
    {
        if (timeIsRunning)
        {
            if(remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
            }
            else
            {
                remainingTime = 0;
                timeIsRunning = false;
                GameLost();
            }
        }
        UpdateUI();
    }

    public void GameWon()
    {
        timeIsRunning = false;
        SceneManager.LoadScene("Heewoo2");
    }

    public void GameLost()
    {
        timeIsRunning = false;
        SceneManager.LoadScene("GameOverScene");
    }

    void UpdateUI()
    {
        timeText.text = "Time: " + Mathf.Clamp(remainingTime, 0, gameTime).ToString("F2");
    }
}
