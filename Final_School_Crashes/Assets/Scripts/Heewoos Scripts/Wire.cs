using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wire : MonoBehaviour
{

    private LineRenderer line; // reference to the Line Renderer component, used to call the line renderer to draw a line in the game itself
    [SerializeField] private string destinationTag; // used to check if the player is releasing the mouse on top of the collider with the correct tag

    Vector3 offset;

    public int totalWires = 4;
    [SerializeField] private int connectedWires = 0;
    public WireManager wireManager;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    private void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();

        wireManager.ConnectWire();
        
    }

    private void OnMouseDrag() // happens while the player is holding their mouse down
    {
        // changing the position of the line inside this function
        line.SetPosition(0, MouseWorldPosition() + offset);
        line.SetPosition(1, transform.position);
    }

    private void OnMouseUp() // calls whenever the player releases their mouse
    {
        // this function checks the point where the player released their mouse with a raycast and if the object they were hovering over is a gameobject with the correct tag
        Vector3 rayOrigin = Camera.main.transform.position;
        Vector3 rayDir = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitInfo;

        if (Physics.Raycast(rayOrigin, rayDir, out hitInfo))
        {
            if (hitInfo.transform.tag == destinationTag)
            {
                line.SetPosition(0, hitInfo.transform.position);
                transform.gameObject.GetComponent<Collider>().enabled = false;

            }
            else
            {
                line.SetPosition(0, transform.position);
            }
        }
    }

    public void ConnectedWire()
    {
        connectedWires++;
        if (connectedWires >= totalWires)
        {
            SceneManager.LoadScene("Victoria2");
        }
    }

    private Vector3 MouseWorldPosition()
    {
        Vector3 mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }




    
}
