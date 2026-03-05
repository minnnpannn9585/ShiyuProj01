using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractiveProp : MonoBehaviour
{
    bool canDestroy = false;
    public GameObject bagCanvas;
    public GameObject propImage;
    public GameObject ClueCanvas;
    public string clue;
    private TMP_Text clueText;

    private void Start()
    {
        clueText = ClueCanvas.GetComponentInChildren<TMP_Text>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canDestroy)
            {
                Destroy(transform.parent.gameObject);
                //bagCanvas.SetActive(true);
                ClueCanvas.SetActive(true);
                clueText.text = clue;
                propImage.SetActive(true);
            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            canDestroy = true;
            transform.parent.GetChild(1).gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canDestroy = false;
            transform.parent.GetChild(1).gameObject.SetActive(false);
        }
    }
}
