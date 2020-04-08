using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    Vector3 prevPos = Vector3.zero;
    Vector3 posDelta = Vector3.zero;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
           
        }
        prevPos = Input.mousePosition;
    }
}
