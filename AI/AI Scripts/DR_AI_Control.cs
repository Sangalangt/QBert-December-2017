using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_AI_Control : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Coily;
    public float Timer;
    public float TimeLimit;
    public float CoilyTime;
    public float CoilySpawn;
    public int TotalMoves = 6;
    private int Moves;
    private int MoveDirection;
    private Vector3 CurLocation;
    private Quaternion CurRotation;
    private GameObject Player;
    private Vector3 PlayerLocation;
    private Vector3 Distance;


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        if (gameObject.tag == "Coily")
        {
            Enemy.transform.Translate(0.0f, 0.375f, 0.0f);
        }
    }

    void Update()
    {
        PlayerLocation = Player.transform.position;
        Timer += Time.deltaTime;
        CurLocation = Enemy.transform.position;
        CurRotation = Enemy.transform.rotation;

        if (Timer > TimeLimit && (gameObject.tag == "Red Egg" || gameObject.tag == "Green Egg" || gameObject.tag == "Slick or Sam"))
        {
            MoveDirection = Random.Range(0, 2);
            //Move Down and Left
            if (MoveDirection == 1)
            {
                Enemy.transform.Translate(0, -1, -1);
                Timer = 0;
                //Moves++;
                //print("moves left");
            }
            //Move Down and Right
            if (MoveDirection == 0)
            {
                Enemy.transform.Translate(1, -1, 0);
                Timer = 0;
                //Moves++;
                //print("moves right");
            }
            //print(Moves);
        }
        if (Timer > TimeLimit && gameObject.tag == "Purple Egg")
        {
            MoveDirection = Random.Range(0, 2);

            //Move Down and Left
            if (MoveDirection == 1 && Moves < TotalMoves)
            {
                Enemy.transform.Translate(0, -1, -1);
                Timer = 0;
                Moves++;
                //print("moves left");
            }
            //Move Down and Right
            if (MoveDirection == 0 && Moves < TotalMoves)
            {
                Enemy.transform.Translate(1, -1, 0);
                Timer = 0;
                Moves++;
                //print("moves right");
            }
            if (Moves == TotalMoves)
            {
                CoilyTime += Time.deltaTime;
                if (CoilyTime >= CoilySpawn)
                {
                    Instantiate(Coily, CurLocation, CurRotation);
                    print("instantiated");
                    Destroy(gameObject);
                }
            }
            //print(Moves);
        }
        if (Timer > TimeLimit && gameObject.tag == "Wrong Way")
        {
            MoveDirection = Random.Range(0, 2);
            //Move Down and Left
            if (MoveDirection == 1)
            {
                Enemy.transform.Translate(1, 0, 1);
                Timer = 0;
                //Moves++;
                //print("moves left");
            }
            //Move Down and Right
            if (MoveDirection == 0)
            {
                Enemy.transform.Translate(0, 1, 1);
                Timer = 0;
                //Moves++;
                //print("moves right");
            }
            //print(Moves);
        }
        if (Timer > TimeLimit && gameObject.tag == "Ugg")
        {
            MoveDirection = Random.Range(0, 2);
            //Move Down and Left
            if (MoveDirection == 1)
            {
                Enemy.transform.Translate(-1, 1, 0);
                Timer = 0;
                //Moves++;
                //print("moves left");
            }
            //Move Down and Right
            if (MoveDirection == 0)
            {
                Enemy.transform.Translate(-1, 0, -1);
                Timer = 0;
                //Moves++;
                //print("moves right");
            }
            //print(Moves);
        }
        if (Timer > TimeLimit && gameObject.tag == "Coily")
        {
            Distance = transform.position - PlayerLocation;
            //print(Distance);
            //Move Up and Right
            if (Distance.y <= -1 && Distance.z <= -1)
            {
                Enemy.transform.Translate(0, 1, 1);
                Timer = 0;
                print("moves up and right");
            }
            //Move Up and Left
            else if (Distance.x >= 1 && Distance.y <= -1)
            {
                Enemy.transform.Translate(-1, 1, 0);
                Timer = 0;
                print("moves up and left");
            }
            //Move Down and Right
            else if (Distance.x <= -1 && Distance.y >= 1)
            {
                Enemy.transform.Translate(0, -1, 1);
                Timer = 0;
                print("moves down and right");
            }
            //Move Down and Left
            else if (Distance.y >= 1 && Distance.z >= 1)
            {
                Enemy.transform.Translate(0, -1, -1);
                Timer = 0;
                print("moves down and left");
            }
            //print(Moves);
        }
    }
}