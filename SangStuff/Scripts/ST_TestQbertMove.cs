using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST_TestQbertMove : MonoBehaviour {
   public GameObject QB;
   public Vector3 spawnspot = new Vector3(0, 7, 6);
   public Vector3 curPosition;
    public bool canMove; 
   private float timer;
    //public MeshRenderer QBertRenderer;
    public GameObject turncontrol;
    // Use this for initialization
    void Start () {
        QB.transform.position = spawnspot;
        canMove = true;

	}
	

	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        curPosition = QB.transform.position;
        if (canMove == true)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                QB.transform.Translate(0, -1, -1);
                turncontrol.transform.eulerAngles = new Vector3(0, 180, 0);
                turnoffrenderer();
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                QB.transform.Translate(0, 1, 1);
                turncontrol.transform.eulerAngles = new Vector3(0, 0, 0);
                turnoffrenderer();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                QB.transform.Translate(1, -1, 0);
                turncontrol.transform.eulerAngles = new Vector3(0, 90, 0);
                turnoffrenderer();
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                QB.transform.Translate(-1, 1, 0);
                turncontrol.transform.eulerAngles = new Vector3(0, 270, 0);
                turnoffrenderer();
            }

        }

        if (Input.GetKeyDown(KeyCode.Escape) && canMove == true)
        {
            canMove = false;
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && canMove == false)
            {
            canMove = true;
            }


    }
    public void turnoffrenderer()
    {
        timer = 0;
    //    QBertRenderer.enabled = false;
    }

}
