/*        
//        Developer Name:Leto Berryman
//         Contribution: Added PC respawn to spawnpoint on ST_TestQbertMove.
//                Feature: Respawn
//                Start & End dates: 11/28/17-Present
//*/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LB_PlayerReset : MonoBehaviour
    {
    public ST_TestQbertMove spawn;
    public LB_GameManager manager;

    public GameObject continuePanel;

    public GameObject qbert;


    private void Start ()
        {
        continuePanel.SetActive (false);
        }

    private void OnTriggerEnter (Collider other)
        {
        if (other.gameObject.tag == "Player")
            {
            qbert.transform.position = spawn.spawnspot;
            manager.qLives--;

            Debug.Log ("life down");
            if (manager.qLives <= 0)
                {
                //SceneManager.LoadScene ("MainMenu");
                continuePanel.SetActive (true);
                }
            }
        }


    }
