using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    [SerializeField] private float m_RotateSpeed =7f;
    public GameObject m_Inscpect_Model;
    [SerializeField] private GameObject m_InGame_Model;
    [SerializeField] private string object_Name_Text;
    [TextArea] [SerializeField] private string Object_discription_text;
    [SerializeField] private InspectController inspectController;


    private void Start()
    {
       
        m_Inscpect_Model.SetActive(false);
        
       
    }
    public void ShowObject()
    {
        inspectController.ShowObject(object_Name_Text, Object_discription_text);
        m_Inscpect_Model.SetActive(true);
        m_InGame_Model.SetActive(false);
     
    }
    public void HideObject()
    {
        inspectController.HideObject();
        m_Inscpect_Model.transform.localRotation = Quaternion.identity;
        m_Inscpect_Model.SetActive(false);
       
        m_InGame_Model.SetActive(true);
    }
    public void RotateObj()
    {
        m_Inscpect_Model.transform.Rotate(-Input.GetAxis("Mouse Y") * m_RotateSpeed, -Input.GetAxis("Mouse X") * m_RotateSpeed, 0, Space.Self);
    }
}
