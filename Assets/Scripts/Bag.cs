using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public GameObject bagCanvas;
    bool isOpen = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            isOpen = !bagCanvas.activeInHierarchy;
            bagCanvas.SetActive(isOpen);
        }
    }
}
