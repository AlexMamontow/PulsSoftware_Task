using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualsRotator : MonoBehaviour
{
    public float rotationSpeed = 10f;

    [SerializeField] MoveController player;

    private int currentRotationDir = -1;

    private void Awake()
    {
        player.OnGravityChanged += ChangeRotationDir;
    }

    private void ChangeRotationDir(float newGravity)
    {
        currentRotationDir = newGravity > 0 ? -1 : 1;
    }

    private void RotateVisuals()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * currentRotationDir * Time.deltaTime);
    }

    private void Update()
    {
        RotateVisuals();
    }


}
