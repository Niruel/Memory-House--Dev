using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp_ScaryPic : MonoBehaviour
{

    public Transform theDest;
    public Text uitext;
    public Image uiimage;
    public Light Light;
    public Material material;

    private void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        uiimage.enabled = true;
        this.transform.Rotate(0f, 0f, 0f);
        Light.enabled = true;
        uitext.text = ("");
        material.DisableKeyword("_EMISSION");

    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
        Light.enabled = false;
        uiimage.enabled = false;
        uitext.text = ("");
    }
}
