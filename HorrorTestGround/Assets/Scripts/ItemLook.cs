using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemLook : MonoBehaviour
{
    private int layernum = 1<<8;
    [SerializeField] LayerMask layerMask;
    [SerializeField] private float maxRayDist =0f;
    [SerializeField] Material highlightMat;
    [SerializeField] Material DefultMat;

    private Transform _transform;


    private void Start()
    {
      
    }

    private void Update()
    {
        if (_transform!=null)
        {
            Renderer selectionRender = _transform.GetComponentInChildren<Renderer>();
            selectionRender.material = DefultMat;
            _transform = null;
        }
        layerMask = layernum;
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit,maxRayDist,layerMask))
        {
            Transform selection = hit.transform;
            
            Renderer selectionRender = selection.GetComponentInChildren<Renderer>();
            if (selectionRender!=null)
            {
                selectionRender.material = highlightMat;    
            }
            _transform = selection;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log(hit.distance);
            
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }
  
}
