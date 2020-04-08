using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemLook : MonoBehaviour
{

    [SerializeField] LayerMask layerMask;
    [SerializeField] private float maxRayDist = 0f;
    [SerializeField] private GameObject userInputKey;
    [SerializeField] private GameObject siteDot;
    public List<GameObject> interactables = new List<GameObject>();
    [SerializeField] Text number;
    //[SerializeField] private TMP_Text userKey;
    private int layernum = 1 << 9;
    public PlayerMover playerMover;
    private ObjectController m_Controller;
    
    bool doOnce;
    int itemNumUpdate = 0;




    private void Start()
    {
        userInputKey.SetActive(false);
        siteDot.SetActive(true);
    }

    private void Update()
    {


        layerMask = layernum;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Debug.DrawRay(transform.position, fwd, Color.red);
        if (Physics.Raycast(transform.position, fwd, out hit, maxRayDist, layerMask))
        {
            
            if (hit.collider.CompareTag("InteractableObj"))
            {
                if (!doOnce)
                {
                    userInputKey.SetActive(true);
                    m_Controller = hit.collider.GetComponent<ObjectController>();
                }
                doOnce = true;
                
                if (Input.GetKeyDown(KeyCode.F))
                {
                    
                   
                    if (!interactables.Contains(m_Controller.m_InGame_Model))
                    {
                        Debug.Log(hit.collider.name);
                        interactables.Add(m_Controller.m_InGame_Model);
                        itemNumUpdate++;
                        number.text = itemNumUpdate.ToString();
                    }
                    userInputKey.SetActive(false);
                    playerMover.enabled = false;
                    siteDot.SetActive(false);
                    m_Controller.ShowObject();
                    
                }
            }  
        }
        else
        {
            if (doOnce)
            {
                doOnce = false;
                userInputKey.SetActive(false);
                m_Controller.HideObject();
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            m_Controller.HideObject();
            playerMover.enabled = true;
            siteDot.SetActive(true);
        }
        if (playerMover.enabled == false)
        {
            m_Controller.RotateObj();

        }
       

    }
}
