using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurnOnandOff : MonoBehaviour {
    public GameObject instructiontext;
    public GameObject close;
    
    // Use this for initialization
    void Start()
    {
        instructiontext.SetActive(false);
        close.SetActive(false);
    }

    public void Instructionsplease()
    {
        instructiontext.SetActive(true);
        close.SetActive(true);
    }

    public void nomoreinstructions()
    {
        instructiontext.SetActive(false);
        close.SetActive(false);
    }
}
