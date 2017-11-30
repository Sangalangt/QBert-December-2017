using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST_TestQbertMove : MonoBehaviour
{
    public GameObject QB;
    public Vector3 spawnspot = new Vector3(0, 7.5f, 6);
    public Vector3 curPosition;
    public float delay = 1;
    private float timer;
    public GameObject QBertRenderer;
    // Use this for initialization
    void Start()
    {
        QB.transform.position = spawnspot;
    }


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        curPosition = QB.transform.position;

        if (timer > delay)
        {
            QBertRenderer.SetActive(true);


            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                QB.transform.Translate(0, 0, -1);
                turnoffrenderer();
            }
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                QB.transform.Translate(0, 1.3f, 1);
                turnoffrenderer();
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                QB.transform.Translate(1, 0, 0);
                turnoffrenderer();
            }
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                QB.transform.Translate(-1, 1.3f, 0);
                turnoffrenderer();
            }
        }

    }
    public void turnoffrenderer()
    {
        timer = 0;
        QBertRenderer.SetActive(false);
    }

}
