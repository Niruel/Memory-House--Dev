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
    public Rigidbody playerRb;
    Quaternion quaternion= Quaternion.Euler(0,0,0);
    public PlayerMover playerMover;
    public Transform origin;
    Quaternion currentRot=Quaternion.Euler(-90,0,90);
    

    private void Start()
    {
        origin.position = _transform.transform.position;
       
        Debug.Log(currentRot);
    }

    private void Update()
    {
        Transform holder = obj.transform;
        

        layerMask = layernum;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, maxRayDist, layerMask))
        {
            Transform selection = hit.transform;

            _transform.transform.position = selection.position;
           

            if (_transform != null)
            {
                

                
                if (Input.GetMouseButtonDown(0))
                {
                    
                    this.transform.localRotation = quaternion;
                    playerMover.enabled = false;
                    if (playerMover.enabled == false)
                    {

                        playerRb.constraints = RigidbodyConstraints.FreezePosition;
                        
                        _transform.transform.position = Vector3.Lerp(_transform.transform.position, holder.transform.position, 2f);
                        rb.useGravity = false;
                        Debug.Log(origin.position);
                    }



                }
                
            }

        }
        if (playerMover.enabled == false)
        {
            _transform.transform.Rotate(-Input.GetAxis("Mouse Y") * 7, -Input.GetAxis("Mouse X") * 7, 0, Space.Self);

        }


        if (Input.GetMouseButtonDown(1))
        {
            _transform.transform.localRotation = currentRot;
            _transform.transform.position = Vector3.Lerp(holder.transform.position, origin.position, 2f);
            
            rb.useGravity = true;
            rb.constraints = RigidbodyConstraints.FreezePositionX;
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
            playerMover.enabled = true;
            playerRb.constraints = RigidbodyConstraints.FreezeRotation;
            


        }

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
