/*        
//        Developer Name:Sang Tiet
//         Contribution: Added pause screen and capibility. Calls game objects to turn on or off.
//                Feature: Switched camera and in world canvas to the set canvas for a puase screen.
//                Start & End dates: 11/28/17-Present
//                References: Unity API
//                        Links:https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html
//*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST_Pause : MonoBehaviour {
    public Transform canvas;
    public Transform HUD;

    // Use this for initialization
    void Start()
    {
        GameObject PauseMenu = GameObject.Find("PauseMenu");
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
        GameObject HUD = GameObject.Find("PauseMenu");
        HUD.gameObject.SetActive(true);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Pause();
            Debug.Log("should be pausing");
        }
    }
    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }

        if (HUD.gameObject.activeInHierarchy == true)
        {
            HUD.gameObject.SetActive(false);
            Time.timeScale = 0;
        }
        else
        {
            HUD.gameObject.SetActive(true);
            Time.timeScale = 1;
        }
    }
}
