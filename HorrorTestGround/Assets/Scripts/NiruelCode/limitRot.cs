using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitRot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rot = transform.rotation.x;
        Debug.Log(rot);
        
        if (this.transform.localRotation.x >= .6f || this.transform.localRotation.x<= -.6f)
        {

            Mathf.Clamp(this.transform.localRotation.x, -.6f, .6f);
        }
    }
}
