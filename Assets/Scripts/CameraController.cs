using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    public List<GameObject> cameras;

    private void Awake()
    {
        if( instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        cameras = new List<GameObject>();
        for (int i = 0; i < transform.childCount; i++)
        {
            cameras.Add(transform.GetChild(i).gameObject);
        }
    }

    private void Start()
    {
        
    }

    public void ChangeCamera(int number)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            cameras[i].SetActive(false);
        }
        cameras[number].SetActive(true);
    }


}
