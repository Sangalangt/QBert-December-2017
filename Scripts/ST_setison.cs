/*        
//        Developer Name:Sang Tiet
//         Contribution: Added time.deltatime and set on off for active variables.
//                Feature: Sets an update state and replaces with artwork.
//                Start & End dates: 11/28/17
//                References: Unity API
//                        Links:https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
//*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST_setison : MonoBehaviour
{
   
    float time;
    public GameObject Updatetext;
    public GameObject Background;

    // Use this for initialization
    void Start()
    {
        Background.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= 3)
        {
            Updatetext.SetActive(false);
            Background.SetActive(true);
        }


    }
}