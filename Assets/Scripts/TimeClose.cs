using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeClose : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("Close", 2f);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
