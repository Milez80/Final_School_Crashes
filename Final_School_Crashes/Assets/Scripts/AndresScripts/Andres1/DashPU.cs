using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPU : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerController>(out PlayerController player))
        {
            player.dash = true;
            Destroy(gameObject);
        }
    }
}
