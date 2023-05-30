  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update

    float rotationSpeed = 100;
    public bool rotup;
    void OnMouseDrag()
    {
      if(!rotup)
      {
        float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Mathf.Deg2Rad;
        transform.Rotate(Vector3.up,rotationX);

      }
      else
      {
        float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Mathf.Deg2Rad;
        transform.Rotate(Vector3.forward,rotationX);
      }
        
    }
}
