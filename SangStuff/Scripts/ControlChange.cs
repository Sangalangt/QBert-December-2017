using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlChange : MonoBehaviour {
    public GameObject QbWASD;
    public GameObject QbWESD;

 
    public void WASDMove()
    {
        QbWASD.SetActive(true);
        QbWESD.SetActive(false);
        QbWASD.GetComponent<ST_TestQbertMove>().canMove = false;
    }
    public void WESDMove()
    {
        QbWASD.SetActive(false);
        QbWESD.SetActive(true);
        QbWESD.GetComponent<ST_TestQbertMove>().canMove = false;
        
    }
}
