using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundController : MonoBehaviour
{
    public int setMaxJumpsTo = 2;

    [SerializeField] MoveController player;
    private void OnTriggerEnter2D(Collider2D collision) //todo disable this layer interaction execpt ground layer
    {
        //player.SetavAvailableJumps();
        player.SetavAvailableJumps(setMaxJumpsTo);
    }
}
