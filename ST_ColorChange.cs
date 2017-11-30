/*        
//        Developer Name:Sang Tiet
//         Contribution: Added Public colors and set Oncollision.
//                Feature: Send To New Scene
//                Start & End dates: 11/28/17-11/29/17
//                References: Unity API
//                        Links:https://docs.unity3d.com/ScriptReference/Material.SetColor.html
///*        
//        Developer Name:Leto Berryman
//         Contribution: Added tileCount int variable for score counting and trigger enter.
//                Feature: Color Change
//                Start & End dates: 11/30/17-Present

 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ST_ColorChange : MonoBehaviour {

    public LB_GameManager manager;

    //public Color StartingColor;
    //public Color ChangingColor;

    public GameObject top;

    private bool switched = false;
    //public int tileCount;
   
	// Use this for initialization
	void Start ()
    {
        //manager.tileCount = 0;    
    //StartingColor = gameObject.GetComponent<Renderer> ().material.color;       	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (manager.tileCount == 28)
            {
            SceneManager.LoadScene ("Level1Load");
            }
        }

    /*For Mouse Click Test
    private void OnMouseDown ()
        {
        Debug.Log ("Color Change");
        top.GetComponent<Renderer> ().material.color = Color.red;
        }*/

    private void OnTriggerEnter (Collider other)
       
    {
        if (other.gameObject.tag == "Player" && !switched)
        {
            Debug.Log("it collided");
            top.GetComponent<Renderer>().material.color = Color.red;
            manager.tileCount++;

            Debug.Log ("tile count = " + manager.tileCount);
            switched = true;
            /*if (manager.tileCount == 28 && manager.qLives > 0)
                {
                SceneManager.LoadScene ("Level1Load");
                }*/
            }
        /*else
        {
            gameObject.GetComponent<Renderer>().material.color = StartingColor;
        }*/
        }
    }
