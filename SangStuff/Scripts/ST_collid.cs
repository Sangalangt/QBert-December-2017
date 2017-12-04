using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ST_collid : MonoBehaviour 
{
    public int curlife;
    public GameObject QB1;
    public GameObject QB2;
    public GameObject GOPanel;
    public int score;
    void start()
    {
        GOPanel.SetActive(false);
        curlife = 3;
    }
    void Update()
    {
        if (curlife == 3)
        {
            QB1.SetActive(true);
            QB2.SetActive(true);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            curlife--;
            if (curlife == 2)
            {
                QB1.SetActive(false);
            }
            if (curlife == 1)
            {
                QB2.SetActive(false);
            }
            else if (curlife == 0)
            {
                GameOver();
            }
        }
        else if (collision.gameObject.tag == "SlickSam")
        {
            score += 300;
        }
        else if(collision.gameObject.tag == "GreenEgg")
        {
            Time.timeScale = 0;
        }
    }
    public void GameOver()
    {
        GOPanel.SetActive(true);
    }
}