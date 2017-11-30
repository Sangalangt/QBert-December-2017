/*        
//        Developer Name:Sang Tiet
//         Contribution: Added time.deltatime to send to mainmenu
//                Feature: Send To New Scene
//                Start & End dates: 11/27/17-Present
//                References: Unity API
//                        Links:https://docs.unity3d.com/ScriptReference/Time-deltaTime.html
//*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ST_OnSplashStart : MonoBehaviour
{

   float time;
    public float timechange;
    public string whichscene;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= timechange)
        {
            SceneManager.LoadScene(whichscene);
        }


    }
}