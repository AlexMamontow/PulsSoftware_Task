using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollisionController : MonoBehaviour
{
    public Action OnGameOver;
    private void OnCollisionEnter2D(Collision2D other) //only with obstacles
    {
        Debug.Log("Collision");
        if (other.gameObject.CompareTag("Obstacle"))
        {            
            OnGameOver?.Invoke();
        }        
    }
}
