using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFall : MonoBehaviour
{
    float wait = 0.3f;
    public GameObject fallingObject;

    void Start()
    {
        InvokeRepeating ("Fall",wait,wait);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fall()
    {
        Instantiate(fallingObject, new Vector3(Random.Range(-10,10),10,0),Quaternion.identity);
    }
}
