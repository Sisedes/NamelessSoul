using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
   [SerializeField] Transform playerTransform;
    [SerializeField] float minX, maxX;
    private void Update()
    {
            transform.position = new Vector3(Mathf.Clamp(playerTransform.position.x,minX,maxX),transform.position.y,transform.position.z);  
    }

}
