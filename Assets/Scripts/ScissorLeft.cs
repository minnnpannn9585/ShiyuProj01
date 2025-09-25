using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorLeft : MonoBehaviour
{
    bool canDestroy = false;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canDestroy)
            {
                Destroy(transform.parent.gameObject);
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
