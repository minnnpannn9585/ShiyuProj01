using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn02 : MonoBehaviour
{
    public GameObject imageOld;
    public GameObject imageNew;
    public GameObject textOld;
    public GameObject textNew;
    public GameObject buttonOld;
    public GameObject buttonNew;
    public GameObject dCanvas;
    
    
    public void BtnTwo()
    {
        buttonOld.SetActive(false);
        buttonNew.SetActive(true);
        imageOld.SetActive(false);
        imageNew.SetActive(true);
        textOld.SetActive(false);
        textNew.SetActive(true);
        dCanvas.SetActive(false);
    }
}
