using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int PlayerNumber = 1;
    Vector3 Direction;
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
            transform.Translate(new Vector3(Input.GetAxis("player1Alt"), 0, 0) * Time.deltaTime * 7);

        }

        if (PlayerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("player2"), 0) * Time.deltaTime * 9);
            transform.Translate(new Vector3(Input.GetAxis("player2Alt"), 0, 0) * Time.deltaTime * 7);
        }
        transform.position = new Vector3(transform.position.x,
        Mathf.Clamp(transform.position.y, -3.5f, 3.5f), transform.position.z);
    }

}
