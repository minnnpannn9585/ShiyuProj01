using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NvyongTrigger : MonoBehaviour
{
    public GameObject nvyong;
    public bool isactive = true;
    public GameObject dialogueCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isactive)
        {
            dialogueCanvas.SetActive(true);
            
            isactive = false;
        }
    }
}
