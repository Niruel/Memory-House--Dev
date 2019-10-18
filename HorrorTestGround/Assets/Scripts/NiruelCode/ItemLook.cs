using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemLook : MonoBehaviour
{
   
    [SerializeField] LayerMask layerMask;
    [SerializeField] private float maxRayDist =0f;
    //[SerializeField] Material highlightMat;
    //[SerializeField] Material DefultMat;
    [SerializeField] GameObject obj;
        
    private int layernum = 1 << 8;
    public GameObject _transform;
     public Rigidbody rb;


    private void Start()
    {
        // objDesc.SetActive(false);
       
        
    }

    private void Update()
    {
        Highlight();
        
    }
  void Highlight()
    {
        if (_transform != null)
        {
          
        }
        layerMask = layernum;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, maxRayDist, layerMask))
        {
            Transform selection = hit.transform;

           _transform.transform.position = selection.position;
            Transform holder = obj.transform;
            // Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            // Debug.Log(hit.distance);
            if (_transform != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    //Debug.Log(_transform);
                    //objDesc.SetActive(true);
                    rb.useGravity = false;
                    _transform.transform.position = Vector3.Lerp(_transform.transform.position, holder.transform.position, 2f);
                    
                   
                  
                  
                }
                if (Input.GetMouseButtonUp(0))
                {
                   // objDesc.SetActive(false);   
                }
                // Debug.Log("This is object tranform");
            }

        }
        else
        {
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            //Debug.Log("Did not Hit");
        }
    }
    void ShowFloatText()
    {

    }
    /*
     * 
     *   Renderer selectionRender = _transform.GetComponentInChildren<Renderer>();
            selectionRender.material = DefultMat;
            _transform = null;
            
            Renderer selectionRender = selection.GetComponentInChildren<Renderer>();
            if (selectionRender != null)
            {
                selectionRender.material = highlightMat;
            }
     */
}
