using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WireManager : MonoBehaviour
{

    public int totalWires = 4;
    [SerializeField] private int connectedWires = 0;
    

    public void ConnectWire()
    {
        connectedWires++;
        if (connectedWires >= totalWires)
        {
            SceneManager.LoadScene("Andres1");
        }
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
