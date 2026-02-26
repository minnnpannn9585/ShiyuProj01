using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zhiren : MonoBehaviour
{
    public GameObject dialogueCanvas;
    private bool isactive = true;
    public GameObject nvyongTrigger;
    public GameObject btn02;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isactive)
        {
            dialogueCanvas.SetActive(true);
            isactive = false;
            nvyongTrigger.SetActive(true);
            btn02.SetActive(true);
        }
    }
}
