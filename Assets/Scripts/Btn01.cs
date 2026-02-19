using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn01 : MonoBehaviour
{
    public GameObject Textold;
    public GameObject Btnold;
    public GameObject Textnew;
    public GameObject Btnnew;
    public GameObject canvas;
    public void BtnOne()
    {
        Textold.SetActive(false);
        Btnold.SetActive(false);
        canvas.SetActive(false);
        Textnew.SetActive(true);
        Btnnew.SetActive(true);
    }
}
