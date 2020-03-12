using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectController : MonoBehaviour
{
    
    
   
    [SerializeField] private GameObject ObjectDiscription;
    [SerializeField] private Text object_Name_Text;
    [SerializeField] private Text Object_discription_text;
  


    private void Start()
    {
        ObjectDiscription.SetActive(false);
    }
    public void ShowObject(string objectName, string objectDes)
    {
        ObjectDiscription.SetActive(true);
        object_Name_Text.text = objectName;
        Object_discription_text.text = objectDes;
        
    }
    public void HideObject()
    {
        ObjectDiscription.SetActive(false);
        object_Name_Text.text = "";
        Object_discription_text.text = "";
        
    }




}
