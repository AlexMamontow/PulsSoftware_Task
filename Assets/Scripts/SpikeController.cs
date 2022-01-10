using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour
{
    public float spikeSpeed = 10f;

    private void Update()
    {
        transform.position+= -Vector3.right * spikeSpeed * Time.deltaTime;
    }
}
