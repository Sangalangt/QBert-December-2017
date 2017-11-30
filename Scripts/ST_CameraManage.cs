/*        
//        Developer Name:Sang Tiet
//         Contribution: Added ispaused bool, gameCamera, PauseCamera, and paused canvas. Intergrated true false to set actives.
//                Feature: Should swap camera in game scene to new camera in pause sccene and set pause scene.
//                Start & End dates: 11/29/17 - Present
//                References: Unity Manual
//                        Links:https://docs.unity3d.com/Manual/HOWTO-UIWorldSpace.html
//*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ST_CameraManage : MonoBehaviour {

    public GameObject GameCamera;
    public GameObject PauseCamera;
    public GameObject pausecanvas;
    public GameObject QbertBackground;
    bool ispaused = false;
	// Use this for initialization
	void Start () {
        QbertBackground.SetActive(true);
        GameCamera.SetActive(true);
        pausecanvas.SetActive(false);
        PauseCamera.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && ispaused == false)
        {
            QbertBackground.SetActive(false);
            GameCamera.SetActive(false);
            pausecanvas.SetActive(true);
            PauseCamera.SetActive(true);
            ispaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && ispaused == true)
        {
            QbertBackground.SetActive(true);
            GameCamera.SetActive(true);
            pausecanvas.SetActive(false);
            PauseCamera.SetActive(false);
            ispaused = false;
        }
	}
}
