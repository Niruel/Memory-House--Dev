using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    [SerializeField]private Game_Manager game_Manager;
    private void Start()
    {
        this.GetComponent<Collider>().isTrigger = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (game_Manager.all_Collected==true)
        {
            this.GetComponent<Collider>().isTrigger = true;
            SceneManager.LoadScene(1);
        }
    }
}
