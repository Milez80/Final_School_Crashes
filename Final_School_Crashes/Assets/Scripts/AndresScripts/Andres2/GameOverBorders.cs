using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverBorders : MonoBehaviour
{
    public GameObject textBorder;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            textBorder.SetActive(true);

            Invoke("Restart", 10);
        }

    }

    public void Restart()
    {
    SceneManager.LoadScene("GameOverScene");
    }
}
