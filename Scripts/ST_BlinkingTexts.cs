/*        
//        Developer Name:Sang Tiet
//         Contribution: Added onenter, Coins, creamount and coded functionality
//                Feature: Added Blinking Text
//                Start & End dates: 11/27/17-Present
//                References: Unity API
//                        Links:https://docs.unity3d.com/ScriptReference/UI.Text.html
//*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ST_BlinkingTexts : MonoBehaviour
{
    public Text onenter;
    public Text Coins;
    private int credamount = 0;

    void Start()
    {
       
        
    }
    void Update()
    {
        Coins.text = credamount.ToString();
        if (Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.Return))
        {
            credamount++;            
        }
        if (credamount == 3)
        {
            onenter.text = " PUSH SPACE OR ENTER TO START";            
        }
        if (credamount == 4 && (Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.Return)))
        {
            SceneManager.LoadScene("Level1Load");
        }
    }
}
