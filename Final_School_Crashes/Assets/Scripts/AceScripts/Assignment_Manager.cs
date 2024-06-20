using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Assignment_Manager : MonoBehaviour
{
    public UnityEngine.UI.Button submitFileButton;
    public UnityEngine.UI.Button submitAssignButton;
    public UnityEngine.UI.Button selectButton;
    public GameObject panel;
    public GameObject assignPanel;
    public GameObject selectPanel;
    public GameObject submittedPanel;
    public GameObject losePanel;

    public float timeLimitS = 60f;
    public TMP_Text timerText;
    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }

        if (assignPanel != null)
        {
            assignPanel.SetActive(false);
        }

        if (selectPanel != null)
        {
            selectPanel.SetActive(false);
        }

        if (submittedPanel != null)
        {
            submittedPanel.SetActive(false);
        }

        if (losePanel != null)
        {
            losePanel.SetActive(false);
        }

        submitAssignButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        timerText.text = "Log Out In: " + (timeLimitS - currentTime).ToString("f0");

        if (currentTime >= timeLimitS)
        {
            ActivateLosePanel();

        }
    }

    public void AssignmentsInstructButton()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }

    public void AssignmentsListButton()
    {
        if (assignPanel != null)
        {
            assignPanel.SetActive(true);
        }
    }

    public void AssignmentsSelectButton()
    {
        if (selectPanel != null)
        {
            selectPanel.SetActive(true);

        }
    }

    public void FileSubmitButton()
    {
        if (selectPanel != null)
        {
            selectPanel.SetActive(true);

            selectButton.interactable = false;
        }
    }

    public void AssignmentFileSubmitButton()
    {
        if (submitFileButton != null)
        {

            submitFileButton.interactable = false;
        }

        submitFileButton.interactable = false;
        selectPanel.SetActive(false);
        submitAssignButton.interactable = true;
    }

    public void AssignmentSubmitButton()
    {
        if (submittedPanel != null)
        {
            submittedPanel.SetActive(true);

            submitAssignButton.interactable = false;

            ActivateWinPanel();
        }
    }

    void ActivateWinPanel()
    {
        StartCoroutine(PlayerWinsCoroutine());
    }

    void ActivateLosePanel()
    {
        StartCoroutine(PlayerLosesCoroutine());
        losePanel.SetActive(true);
    }


    IEnumerator PlayerLosesCoroutine()
    {
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene("GameOverScene");
    }

    IEnumerator PlayerWinsCoroutine()
    {
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene("Andres1");
    }
}
