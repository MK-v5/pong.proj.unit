using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int PlayerNumber = 1;
    public float moveSpeed;
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
            transform.Translate(new Vector3(0, Input.GetAxis("player1") * Time.deltaTime * 9, 0));
        }
        
        if (PlayerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("player2") * Time.deltaTime * 9, 0));
        }
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4.3f, 4.3f), transform.position.z);
    }

}
