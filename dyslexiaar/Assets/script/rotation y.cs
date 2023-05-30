using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationY : MonoBehaviour
{
   float rotationSpeed = 100;
    void OnMouseDrag()
    {
        float rotationY = Input.GetAxis("Mouse Y") * rotationSpeed * Mathf.Deg2Rad;
        transform.Rotate(Vector3.right,-rotationY);
    }
}
