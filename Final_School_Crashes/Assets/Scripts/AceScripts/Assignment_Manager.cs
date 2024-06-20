using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment_Manager : MonoBehaviour
{
    public GameObject panel;
    public GameObject assignPanel;

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
}
