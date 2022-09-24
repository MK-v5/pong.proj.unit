using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float MoveSpeed;
    public float x = 1f;
    public float y = -1f;
    Vector2 BallDirection;
    // Start is called before the first frame update
    //new direction variable
    void Start()
    {
        BallDirection = new Vector2(x, y);
        BallDirection = new Vector2(Random.Range(-2f, 2f), Random.Range(-2f, 2f));
        BallDirection = BallDirection.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        //ball moves! yay!
        //transform.Translate(MoveSpeed, MoveSpeed,Time.deltaTime);
        //transform.Translate(0.01f, 0.01f, Time.deltaTime);
        //transform.Translate(Vector2.up * Time.deltaTime);
        x = BallDirection.x;
        y = BallDirection.y;
        transform.Translate(BallDirection * MoveSpeed * Time.deltaTime);
        //if ball bounce against top or bottom. do BallDirection(x, y * -1)
        //if ball bounce against playersprite. do BallDirecton(x, -1 * y)
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "wall1")
        {
            BallDirection = new Vector2(x, y * -1);
        }
        if (collision.gameObject.name == "wall2")
        {
            BallDirection = new Vector2(x, y * -1);
        }
        if (collision.gameObject.name == "player1")
        {
            BallDirection = new Vector2(x * -1, y);    
        }
        if (collision.gameObject.name == "player2")
        {
            BallDirection = new Vector2(x * -1, y);
        }
     
    }
}
