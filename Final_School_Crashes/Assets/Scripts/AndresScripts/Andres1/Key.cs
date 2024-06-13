using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour
{
    [SerializeField]
    private string colliderScript;


    [SerializeField]
    private UnityEvent _collisionEnter;
    [SerializeField]
    private UnityEvent _collisionExit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent(colliderScript))
        {
            _collisionEnter?.Invoke();
            Debug.Log("if");
        }
        Debug.Log("touch");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent(colliderScript))
        {
            _collisionExit?.Invoke();
        }
    }
}
