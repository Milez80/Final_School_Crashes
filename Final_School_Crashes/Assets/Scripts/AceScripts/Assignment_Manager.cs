using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Assignment_Manager : MonoBehaviour
{
    public Button submitFileButton;
    public Button submitAssignButton;
    public Button selectButton;
    public GameObject panel;
    public GameObject assignPanel;
    public GameObject selectPanel;
    public GameObject submittedPanel;

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
    }

    // Update is called once per frame
    void Update()
    {
        
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
        if (selectPanel != null)
        {

            submitFileButton.interactable = false;
        }

        selectPanel.SetActive(false);
    }

    public void AssignmentSubmitButton()
    {
        if (submittedPanel != null)
        {
            submittedPanel.SetActive(true);

            submitAssignButton.interactable = false;
        }
    }
}
