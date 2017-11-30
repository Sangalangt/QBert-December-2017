/*        
//        Developer Name:Sang Tiet
//         Contribution: Added Public colors and set Oncollision.
//                Feature: Send To New Scene
//                Start & End dates: 11/28/17-Present
//                References: Unity API
//                        Links:https://docs.unity3d.com/ScriptReference/Material.SetColor.html
//*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST_ColorChange : MonoBehaviour {

    public Color StartingColor;
    public Color ChangingColor;
   
	// Use this for initialization
	void Start ()
    {
        StartingColor = gameObject.GetComponent<Renderer>().material.color;       	
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("it collided");
            gameObject.GetComponent<Renderer>().material.color = ChangingColor;
        }
        /*else
        {
            gameObject.GetComponent<Renderer>().material.color = StartingColor;
        }*/
    }
}
