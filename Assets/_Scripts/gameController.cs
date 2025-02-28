﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{
    public int p1Score;
    public int p2Score;
    public Text p1ScoreText;
    public Text p2ScoreText;
    public GameObject win;
    public GameObject win2;
    public GameObject pong;
    public GameObject pongSpawn;
    public GameObject menu;

    public bool start = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        p1Score = 0;
      
        
    }

    // Update is called once per frame
    void Update()
    {
        p1ScoreText.text = p1Score.ToString();
        p2ScoreText.text = p2Score.ToString();
        winCon();

        if(start == true)
        {
            startGame();
            start = false;
        }
        
    }

    public void startGame()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void winCon()
    {
        if(p1Score == 3)
        {

            win.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        if(p2Score == 3)
        {

            win2.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void point1()
    {
        p1Score++;
        Instantiate(pong, pongSpawn.transform.position, pongSpawn.transform.rotation);
    } 
    public void point2()
    {
        p2Score++;
        Instantiate(pong, pongSpawn.transform.position, pongSpawn.transform.rotation);
    }
}

