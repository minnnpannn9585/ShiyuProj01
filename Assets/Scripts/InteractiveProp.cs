using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveProp : MonoBehaviour
{
    bool canDestroy = false;
    public GameObject bagCanvas;
    public GameObject propImage;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canDestroy)
            {
                Destroy(transform.parent.gameObject);
                bagCanvas.SetActive(true);
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
