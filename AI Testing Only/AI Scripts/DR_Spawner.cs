using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DR_Spawner : MonoBehaviour
{
    public GameObject WrongWaySpawnPoint;
    public GameObject UggSpawnPoint;
    public GameObject GreenEgg;
    public GameObject RedEgg;
    public GameObject PurpleEgg;
    public GameObject Slick;
    public GameObject Sam;
    public GameObject WrongWay;
    public GameObject Ugg;
    private Vector3 WWCurLocation;
    private Vector3 UggCurLocation;
    private float SinceCoily;
    public float CoilyMax;
    private float SinceSandS;
    public float SandSMax;
    private float SinceGreen;
    public float GreenMax;
    public float TimeLimit;
    private float Timer;
    private int SpawnChoice;

    void Start()
    {
        WWCurLocation = WrongWaySpawnPoint.transform.position;
        UggCurLocation = UggSpawnPoint.transform.position;
        Timer = 0;
    }

    void Update ()
    {
        Timer += Time.deltaTime;
        SpawnChoice = Random.Range(0, 7);
        if (Timer > TimeLimit)
        {
            if(SpawnChoice == 0 && SinceGreen > GreenMax)
            {
                SinceGreen = 0;
                Instantiate(GreenEgg, transform.position, transform.rotation);
                Timer = 0;
                SinceCoily++;
                SinceSandS++;
            }
            if (SpawnChoice == 1)
            {
                Instantiate(RedEgg, transform.position, transform.rotation);
                Timer = 0;
                SinceCoily++;
                SinceSandS++;
                SinceGreen++;
            }
            if (SpawnChoice == 2 && SinceCoily > CoilyMax)
            {
                SinceCoily = 0;
                Instantiate(PurpleEgg, transform.position, transform.rotation);
                Timer = 0;
                SinceSandS++;
                SinceGreen++;
            }
            if (SpawnChoice == 3 && SinceSandS > SandSMax)
            {
                SinceSandS = 0;
                Instantiate(Slick, transform.position, transform.rotation);
                Timer = 0;
                SinceCoily++;
                SinceGreen++;
            }
            if (SpawnChoice == 4 && SinceSandS > SandSMax)
            {
                SinceSandS = 0;
                Instantiate(Sam, transform.position, transform.rotation);
                Timer = 0;
                SinceCoily++;
                SinceGreen++;
            }
            if (SpawnChoice == 5)
            {
                Instantiate(WrongWay, WWCurLocation, transform.rotation);
                Timer = 0;
                SinceCoily++;
                SinceSandS++;
                SinceGreen++;
            }
            if (SpawnChoice == 6)
            {
                Instantiate(Ugg, UggCurLocation, transform.rotation);
                Timer = 0;
                SinceCoily++;
                SinceSandS++;
                SinceGreen++;
            }
        }
	}
}
