using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoUI : MonoBehaviour
{
    public TMP_Text collectibles;

    // Update is called once per frame
    void Update()
    {
        collectibles.text = "Collectibles: " + ScoreManager.instance.score;
    }
}
