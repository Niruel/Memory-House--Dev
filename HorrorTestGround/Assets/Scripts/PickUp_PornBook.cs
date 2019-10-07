using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp_PornBook : MonoBehaviour
{

    public Transform theDest;
    public Text uitext;

    private void OnMouseDown()
    {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.Translate(0f, 1.0f, 0f);
        this.transform.parent = GameObject.Find("PlayerEmpty").transform;
        uitext.text = ("父の宝物");

    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
        uitext.text = ("");
    }
}
