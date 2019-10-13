    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextLook : MonoBehaviour
{
    [SerializeField] TextMeshPro textMesh;
    public Transform target;
    public Transform placeStart;
    // Start is called before the first frame update
    void Start()
    {
        textMesh.GetComponent<TextMeshPro>();
        
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(   target ); 
    }
}
