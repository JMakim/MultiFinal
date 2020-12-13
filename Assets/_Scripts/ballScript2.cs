using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript2 : MonoBehaviour
{

    public float x;
    public float y;
    public float xx;
    public float yy;
    public Vector2 ball;
    public GameObject gc;
    public gameController g;

    // Start is called before the first frame update
    void Start()
    {
        x = 0.5f;
        y = 0.5f;
        xx = 0.05f;
        yy = 0.05f;
}

    // Update is called once per frame
    void Update()
    {
        x = x + xx * Time.deltaTime;
        y = y + yy * Time.deltaTime;

        ball = new Vector2(x, y);
        Launch();
        gc = GameObject.Find("gameController");
        g = gc.GetComponent<gameController>();
    }

    public void Launch()
    {
        transform.Translate(ball * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            Debug.Log("wall hit");
            y = y * -1;
            yy = yy * -1;
        }
        if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
        {
            x = x * -1;
            xx = xx * -1;
        }
        if (collision.gameObject.CompareTag("goal1"))
        {
            g.GetComponent<gameController>().point1();
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("goal2"))
        {
            g.GetComponent<gameController>().point2();
            Destroy(this.gameObject);
        }
    }
}
