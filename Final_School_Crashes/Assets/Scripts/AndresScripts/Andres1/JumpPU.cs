using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPU : MonoBehaviour
{
    public int additonalJumps = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerController>(out PlayerController player))
        {
            player.extraJumpCount = additonalJumps;
            Destroy(gameObject);
        }
    }
}
