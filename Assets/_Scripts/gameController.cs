using System.Collections;
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

    // Start is called before the first frame update
    void Start()
    {
        p1Score = 0;
        p2Score = 0;
        Instantiate(pong, pongSpawn.transform.position, pongSpawn.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        p1ScoreText.text = p1Score.ToString();
        p2ScoreText.text = p2Score.ToString();
        winCon();
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

