using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDemo : MonoBehaviour
{
   [SerializeField]Animator aniClip;
    [SerializeField] GameObject ui;
    private void Start()
    {
        ui.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        if (aniClip.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !aniClip.IsInTransition(0))
        {
            Debug.Log("Nam");
            ui.SetActive(true);
        }
    }
}
