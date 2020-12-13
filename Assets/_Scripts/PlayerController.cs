using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public GameObject cube;
    public NetworkMan netMan;
    Vector3 positionVector3;

    public float speed = 5;
    public Rigidbody2D rb;

    public bool isPlayer1 = false;
    public bool isPlayer2 = false;


    GameObject Player1;
    GameObject Player2;

    public GameObject x;


    public


    // Start is called before the first frame update
    void Start()
    {

        Player1 = GameObject.FindWithTag("Player1");
        Player2 = GameObject.FindWithTag("Player2");

        rb = gameObject.GetComponent<Rigidbody2D>();

        //SendPos();
        //InvokeRepeating("SendPos", 1, 0.033f);
        
    }




    void Update()
    {
        Movement();
        whoIsWho();
  
    }

    public void whoIsWho()
    {
        if (isPlayer1 == true)
            x = Player1;
        if (isPlayer2 == true)
            x = Player2;
    }

    public void Movement()
    {

        if (Input.GetKey(KeyCode.UpArrow))
            x.transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            x.transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    //public void SendPos()
    //{
    //    //positionVector3 = gameObject.transform.position;
    //    //rotationVector3 = gameObject.transform.rotation.eulerAngles;

    //    netMan.SendPosition(positionVector3);
    //}
}
