using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript01 : MonoBehaviour
{
    bool b1 = true;

    float a = 0f;
    float fadespeed = 0.1f;
    public Transform playerPos;



    private void Update()
    {
        Debug.Log(b1);
        Debug.Log(a);
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonDown(0) && b1 == true)
        {
            playerPos.Translate(Vector3.forward);
            {

            }
        }
        /*if(Input.GetMouseButtonDown(1) && b1 == false){
            other.gameObject.transform.position = new Vector3(0f, 2, 0);
            b1 = true;
        }*/

    }



}



