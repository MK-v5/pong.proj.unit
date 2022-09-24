using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BallAlt : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 Direction;
    public float moveSpeed;
    void Start()
    {
        Direction = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Direction * moveSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Direction = Vector3.Reflect(Direction, collision.contacts[0].normal);
        }
        if (collision.gameObject.CompareTag("Paddle"))
        {
            Direction = Vector3.Reflect(Direction, collision.contacts[0].normal);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LBarrier"))
        {
            ResetBall();
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP2Score();
        }
        if (collision.gameObject.CompareTag("RBarrier"))
        {
            ResetBall();
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP1Score();
        }
    }
    private void ResetBall()
    {
        transform.position = new Vector3(0, 0, 0);
        Direction = new Vector2(Random.Range(-2f, 2f), Random.Range(-2f, 2f));
        Direction = Direction.normalized;
    }
}

