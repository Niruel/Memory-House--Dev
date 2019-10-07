using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp_Book : MonoBehaviour
{

    public Transform theDest;
    public Text uitext;

    private void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.Translate(0f, 0.5f, 0f);
        this.transform.Rotate(80f, 0f, 0f);
        uitext.text = ("絵本");

    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
        uitext.text = ("");
    }
}
