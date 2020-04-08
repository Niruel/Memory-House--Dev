using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Game_Manager : MonoBehaviour
{
    [SerializeField] private List <GameObject> itemsList = new List<GameObject>();
    [SerializeField]ItemLook items;
    public bool all_Collected;
    private void Start()
    {
        itemsList = items.interactables;
        itemsList.Clear();
        all_Collected = false;
        Cursor.visible = false;
    }
    private void Update()
    {
        GameOver();
    }
    public void GameOver()
    {
        if (itemsList.Count == 3)
        {
            all_Collected = true;
        }
    }
 
}
