using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class GameManager_AceWater : MonoBehaviour
{
    public float currentWater;
    public float WaterPerClick;
    public float winConditionWater = 10000f;
    public GameObject winPanel;
    public GameObject losePanel;

    public float timeLimitS = 60f;
    public TMP_Text timerText;
    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        timerText.text = "Time: " + (timeLimitS - currentTime).ToString("f0");

        if (currentTime >= timeLimitS)
        {
            if (currentWater >= winConditionWater)
            {
                ActivateWinPanel();
            }
            else
            {
                ActivateLosePanel();
            }
        }
    }

    public void WaterButton()
    {
        currentWater += WaterPerClick;

        if (currentWater >= winConditionWater && currentTime < timeLimitS)
        {
            ActivateWinPanel();
        }
    }

    void ActivateWinPanel()
    {
        winPanel.SetActive(true);
        Time.timeScale = 0;
        SceneManager.LoadScene("Andres1");
    }

    void ActivateLosePanel()
    {
        losePanel.SetActive(true);
        Time.timeScale = 0;
        currentTime = 0f;
    }
}
