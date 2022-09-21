using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int PlayerNumber = 1;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;
    }
    void Update()
    {
        if (PlayerNumber == 1)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("player1") * Time.deltaTime * 10, 0));
        }
        
        if (PlayerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("player2") * Time.deltaTime * 10, 0));
        }
    }
}
