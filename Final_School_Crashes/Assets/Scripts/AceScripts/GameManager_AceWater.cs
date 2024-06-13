using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager_AceWater : MonoBehaviour
{
    public float currentWater;
    public float WaterPerClick;
    public float winConditionWater = 10000f;

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
    }

    public void WaterButton()
    {
        currentWater += WaterPerClick;

        if (currentWater >= winConditionWater && currentTime < timeLimitS)
        {
            //win panel
        }
    }
}
