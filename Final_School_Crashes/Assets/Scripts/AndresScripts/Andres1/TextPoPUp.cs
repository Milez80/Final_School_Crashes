using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextPoPUp : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI yourText;

    void Start()
    {
        yourText.enabled = false; 
    }


    // Assuming you're using a 2D platform

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            yourText.enabled = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            yourText.enabled = false;
        }
    }
}
