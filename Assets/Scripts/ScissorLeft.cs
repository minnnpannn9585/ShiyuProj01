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
                Destroy(this.gameObject);
            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            canDestroy = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canDestroy = false;
        }
    }
}
