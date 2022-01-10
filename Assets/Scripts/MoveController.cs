using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveController : MonoBehaviour
{
    public float jumpStrength = 10f;
    public int maxJumpsCount = 2;

    [SerializeField] private Rigidbody2D rb;
    
    private int currentJumps;

    public Action<float> OnGravityChanged;

    private void Start()
    {
        currentJumps = maxJumpsCount;
    }
    public void Jump()
    {
        if (currentJumps >= maxJumpsCount)
        {
            Debug.Log("You can`t jump right now");
            return;
        }
        Vector2 jumpDir = (Vector2.up * rb.gravityScale).normalized;
        rb.AddForce(jumpDir*jumpStrength, ForceMode2D.Impulse);
        currentJumps++;
        if(currentJumps==maxJumpsCount)
        {
            ChangeGravity();
        }
    }

    private void ChangeGravity()
    {
        rb.gravityScale = -rb.gravityScale;
        OnGravityChanged?.Invoke(rb.gravityScale);
    }

    public void SetavAvailableJumps(int maxjumps)
    {
        //Debug.Log("Set jumps to "+maxjumps);
        maxJumpsCount = maxjumps;
        currentJumps = 0;
    }
}
