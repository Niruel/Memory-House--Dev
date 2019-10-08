    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLook : MonoBehaviour
{
    [SerializeField] TextMesh textMesh;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        textMesh.GetComponent<TextMesh>();
        textMesh.text = "I did not want to do this is \n \n \n but fuck it";
        Debug.Log(textMesh);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(   target ); 
    }
}
