using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class WaterGoal : MonoBehaviour
{
    public float goal;
    float prevGoal = 0;
    public Slider waterBar;
    public GameManager_AceWater GameManager_AceWater;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waterBar.value = (GameManager_AceWater.currentWater - prevGoal) / (goal - prevGoal);

        if (GameManager_AceWater.currentWater >= goal)
        {
            prevGoal = goal;
            goal *= 2;
        }
    }
}
