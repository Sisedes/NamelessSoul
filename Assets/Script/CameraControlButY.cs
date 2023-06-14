using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlButY : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float minY, maxY;
    private void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(playerTransform.position.y, minY, maxY), transform.position.z);
    }
}
