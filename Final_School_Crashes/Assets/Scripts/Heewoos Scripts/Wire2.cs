using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire2 : MonoBehaviour
{

    public WireManager wireManager;


    private void OnMouseDown()
    {
        wireManager.ConnectWire();

        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}