using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalllClimbPU : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerController>(out PlayerController player))
        {
            player.wallClimb = true;
            Destroy(gameObject);
        }
    }
}
